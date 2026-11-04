using UnityEngine;
using UnityEngine.XR;

/// <summary>
/// Minimal self-contained tabletop RC test scene.
/// Attach this component to the existing XR Origin. It does not modify the XR rig.
/// Left controller thumbstick steers; right trigger accelerates; left trigger brakes.
/// </summary>
public class MinimalTabletopDemo : MonoBehaviour
{
    [Header("Simple test vehicle")]
    [SerializeField] private float motorForce = 1.8f;
    [SerializeField] private float brakeForce = 2.5f;
    [SerializeField] private float steeringTorque = 0.9f;

    private Rigidbody buggyBody;
    private InputDevice leftController;
    private InputDevice rightController;
    private Vector2 steeringInput;
    private float throttleInput;
    private float brakeInput;

    private void Start()
    {
        BuildTestArea();
        RefreshControllers();
    }

    private void Update()
    {
        if (!leftController.isValid || !rightController.isValid)
            RefreshControllers();

        if (leftController.isValid)
            leftController.TryGetFeatureValue(CommonUsages.primary2DAxis, out steeringInput);
        else
            steeringInput = Vector2.zero;

        if (rightController.isValid)
            rightController.TryGetFeatureValue(CommonUsages.trigger, out throttleInput);
        else
            throttleInput = 0f;

        if (leftController.isValid)
            leftController.TryGetFeatureValue(CommonUsages.trigger, out brakeInput);
        else
            brakeInput = 0f;
    }

    private void FixedUpdate()
    {
        if (buggyBody == null) return;

        buggyBody.AddForce(buggyBody.transform.forward * (throttleInput * motorForce), ForceMode.Acceleration);

        if (brakeInput > 0.05f && buggyBody.velocity.sqrMagnitude > 0.001f)
            buggyBody.AddForce(-buggyBody.velocity.normalized * (brakeInput * brakeForce), ForceMode.Acceleration);

        float speedFactor = Mathf.Clamp(buggyBody.velocity.magnitude / 0.35f, 0.2f, 1f);
        buggyBody.AddTorque(Vector3.up * (steeringInput.x * steeringTorque * speedFactor), ForceMode.Acceleration);
    }

    private void RefreshControllers()
    {
        leftController = InputDevices.GetDeviceAtXRNode(XRNode.LeftHand);
        rightController = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);
    }

    private void BuildTestArea()
    {
        Camera headsetCamera = Camera.main;
        Vector3 origin;
        Quaternion heading;

        if (headsetCamera != null)
        {
            Vector3 forward = Vector3.ProjectOnPlane(headsetCamera.transform.forward, Vector3.up).normalized;
            if (forward.sqrMagnitude < 0.01f) forward = Vector3.forward;
            heading = Quaternion.LookRotation(forward, Vector3.up);
            origin = headsetCamera.transform.position + forward * 0.65f + Vector3.down * 0.75f;
        }
        else
        {
            heading = Quaternion.identity;
            origin = new Vector3(0f, 0.8f, 0.8f);
            Debug.LogWarning("MinimalTabletopDemo: Main Camera not found. Using fallback test-area position.");
        }

        GameObject testArea = new GameObject("Generated Tabletop RC Test Area");
        testArea.transform.SetPositionAndRotation(origin, heading);

        Material boardMaterial = MakeMaterial(new Color(0.16f, 0.20f, 0.17f));
        Material railMaterial = MakeMaterial(new Color(0.35f, 0.38f, 0.34f));
        Material buggyMaterial = MakeMaterial(new Color(0.05f, 0.30f, 0.85f));
        Material wheelMaterial = MakeMaterial(new Color(0.025f, 0.025f, 0.025f));
        Material coneMaterial = MakeMaterial(new Color(1f, 0.32f, 0.035f));

        CreatePrimitive("Tabletop", PrimitiveType.Cube, testArea.transform,
            new Vector3(0f, 0f, 0f), new Vector3(0.85f, 0.035f, 0.60f), boardMaterial);

        // Low perimeter rails keep the test buggy on the miniature board.
        CreatePrimitive("Back rail", PrimitiveType.Cube, testArea.transform,
            new Vector3(0f, 0.035f, 0.29f), new Vector3(0.85f, 0.07f, 0.018f), railMaterial);
        CreatePrimitive("Front rail", PrimitiveType.Cube, testArea.transform,
            new Vector3(0f, 0.035f, -0.29f), new Vector3(0.85f, 0.07f, 0.018f), railMaterial);
        CreatePrimitive("Left rail", PrimitiveType.Cube, testArea.transform,
            new Vector3(-0.415f, 0.035f, 0f), new Vector3(0.018f, 0.07f, 0.58f), railMaterial);
        CreatePrimitive("Right rail", PrimitiveType.Cube, testArea.transform,
            new Vector3(0.415f, 0.035f, 0f), new Vector3(0.018f, 0.07f, 0.58f), railMaterial);

        // Four visual markers, not a prescribed driving path.
        CreateMarker(testArea.transform, new Vector3(-0.31f, 0.055f, -0.19f), coneMaterial);
        CreateMarker(testArea.transform, new Vector3(0.31f, 0.055f, -0.19f), coneMaterial);
        CreateMarker(testArea.transform, new Vector3(-0.31f, 0.055f, 0.19f), coneMaterial);
        CreateMarker(testArea.transform, new Vector3(0.31f, 0.055f, 0.19f), coneMaterial);

        GameObject buggy = new GameObject("Simple RC Buggy");
        buggy.transform.SetParent(testArea.transform, false);
        buggy.transform.localPosition = new Vector3(0f, 0.105f, -0.10f);

        GameObject chassis = CreatePrimitive("Blue buggy chassis", PrimitiveType.Cube, buggy.transform,
            new Vector3(0f, 0f, 0f), new Vector3(0.15f, 0.045f, 0.23f), buggyMaterial);

        buggyBody = buggy.AddComponent<Rigidbody>();
        buggyBody.mass = 0.35f;
        buggyBody.drag = 0.65f;
        buggyBody.angularDrag = 1.5f;
        buggyBody.interpolation = RigidbodyInterpolation.Interpolate;
        buggyBody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
        buggyBody.centerOfMass = new Vector3(0f, -0.015f, 0f);

        // The chassis primitive supplies the main collider. Remove its automatically generated
        // collider because the Rigidbody is on the parent; add one collider to the vehicle root.
        Collider chassisCollider = chassis.GetComponent<Collider>();
        if (chassisCollider != null) Destroy(chassisCollider);
        BoxCollider bodyCollider = buggy.AddComponent<BoxCollider>();
        bodyCollider.size = new Vector3(0.15f, 0.045f, 0.23f);

        CreateWheel(buggy.transform, new Vector3(-0.09f, -0.012f, 0.075f), wheelMaterial);
        CreateWheel(buggy.transform, new Vector3(0.09f, -0.012f, 0.075f), wheelMaterial);
        CreateWheel(buggy.transform, new Vector3(-0.09f, -0.012f, -0.075f), wheelMaterial);
        CreateWheel(buggy.transform, new Vector3(0.09f, -0.012f, -0.075f), wheelMaterial);

        Debug.Log("Minimal tabletop RC test area created. Left thumbstick steers, right trigger accelerates, left trigger brakes.");
    }

    private static Material MakeMaterial(Color color)
    {
        Shader shader = Shader.Find("Universal Render Pipeline/Lit");
        if (shader == null) shader = Shader.Find("Standard");
        Material material = new Material(shader);
        material.color = color;
        return material;
    }

    private static GameObject CreatePrimitive(string objectName, PrimitiveType type, Transform parent,
        Vector3 localPosition, Vector3 localScale, Material material)
    {
        GameObject item = GameObject.CreatePrimitive(type);
        item.name = objectName;
        item.transform.SetParent(parent, false);
        item.transform.localPosition = localPosition;
        item.transform.localScale = localScale;
        Renderer renderer = item.GetComponent<Renderer>();
        if (renderer != null) renderer.material = material;
        return item;
    }

    private static void CreateMarker(Transform parent, Vector3 localPosition, Material material)
    {
        CreatePrimitive("Orange marker", PrimitiveType.Cylinder, parent, localPosition,
            new Vector3(0.025f, 0.045f, 0.025f), material);
    }

    private static void CreateWheel(Transform parent, Vector3 localPosition, Material material)
    {
        GameObject wheel = CreatePrimitive("Buggy wheel", PrimitiveType.Cylinder, parent, localPosition,
            new Vector3(0.035f, 0.035f, 0.035f), material);
        wheel.transform.localRotation = Quaternion.Euler(0f, 0f, 90f);
        Collider wheelCollider = wheel.GetComponent<Collider>();
        if (wheelCollider != null) Destroy(wheelCollider);
    }
}
