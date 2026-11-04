# Change Register
Project: Meta Quest 3 Mixed Reality RC Racing
Version: 1.0
Status: DEVELOPMENT
Date: 2026-11-04

## Change records

### RC-CHG-0001
- Status: RECORDED
- Request: Resume the Meta Quest 3 Mixed Reality RC Racing project and use the newly created dedicated GitHub repository.
- Scope: Verify repository ownership/access and initialise the project governance records only: PROJECT_SPEC.md, CHANGE_REGISTER.md and MANIFEST.md.
- Explicit exclusions: No Unity project, source code, assets, packages, configuration or implementation files are to be created in this change.
- Files created: PROJECT_SPEC.md, CHANGE_REGISTER.md, MANIFEST.md.
- Preserved functions: None applicable. The repository was confirmed empty before initialisation.
- Checks: Repository lookup succeeded; repository is PhilColbert/Meta-Quest-3-Mixed-Reality-RC-Racing; authenticated permissions include admin and push; default branch main; repository size was zero before initialisation.
- Results: Governance baseline initialised. No implementation or runtime tests performed.
- Issues/deviations: No prior RC Racing spec/register/manifest was found in the available Library/history search. Initial spec distinguishes previously confirmed requirements from proposals and unresolved decisions.
- Version transition: 0.0 -> 0.1.

### RC-CHG-0002
- Status: RECORDED
- Request: Record installed Unity Editor versions.
- Scope: Record Unity 6.6 and Unity 6.3 LTS paths; leave selection and Android module availability unresolved.
- Files changed: PROJECT_SPEC.md, CHANGE_REGISTER.md, MANIFEST.md.
- Checks: All three files fetched after saving; version 0.2 SHAs recorded in prior manifest.
- Version transition: 0.1 -> 0.2.

### RC-CHG-0003
- Status: RECORDED
- Request: Record user confirmation that Android Build Support, Android SDK & NDK Tools, and OpenJDK are installed for Unity 6.3 LTS.
- Scope: Record module installation; leave editor selection unresolved.
- Files changed: PROJECT_SPEC.md, CHANGE_REGISTER.md, MANIFEST.md.
- Checks: All three files fetched after saving and version 0.3 contents verified.
- Version transition: 0.2 -> 0.3.

### RC-CHG-0004
- Status: RECORDED
- Request: User accepted Unity 6.3 LTS as the project editor.
- Scope: Fix Unity 6.3 LTS (6000.3.26f1) and update governance files.
- Files changed: PROJECT_SPEC.md, CHANGE_REGISTER.md, MANIFEST.md.
- Checks: All three files fetched after saving; editor selection and version 0.4 verified.
- Version transition: 0.3 -> 0.4.

### RC-CHG-0005
- Status: LOGGED BEFORE ACTION
- Request: Proceed with creating the local Unity project after the user selected a project location in Unity Hub.
- Scope: User to create a project named RC Buggy MR Racing using Unity 6.3 LTS (6000.3.26f1) and the Mixed Reality (MR) template, at the location now selected in Unity Hub. This entry authorises only this initial project creation step.
- Explicit exclusions: No additional packages, source code, assets, gameplay implementation, settings changes or repository source files are included. Do not alter other project settings.
- Files in scope: Local Unity-generated project files at the user's selected location; governance completion record after the user confirms creation.
- Preserved functions: No application functions exist yet. Preserve all FIXED requirements and existing project scope.
- Checks planned: User confirms Unity Hub creation completes without errors; then inspect project structure and record what was actually generated. No build or headset test is implied.
- Version transition: 0.4 -> 0.5 (creation action logged; completion pending).



### RC-CHG-0005
- Status: COMPLETED - USER CONFIRMED
- Request: Create the local Unity project after the user selected a project location in Unity Hub.
- Scope: User created a project named RC Buggy MR Racing using Unity 6.3 LTS (6000.3.26f1) and the Mixed Reality (MR) template.
- Files: Unity generated the local project at the location selected in Unity Hub. Exact path and generated file inventory have not been captured. No Unity implementation files were added to the GitHub repository.
- Preserved functions: No application functions existed before this step. All FIXED requirements and existing project scope remain unchanged.
- Checks: Screenshot visually confirms the Unity Editor opened with the project and Mixed Reality template scene. This is not a full file-system audit.
- Tests: No build, compile validation, Quest deployment, headset test or runtime gameplay test performed.
- Issues: Exact local project path and generated file inventory remain unverified.
- Version transition: 0.5 -> 0.6.

### RC-CHG-0006
- Status: LOGGED BEFORE IMPLEMENTATION
- Request: Use a tabletop track and make the simplest possible prototype so it can be tested.
- Scope: Fix tabletop as the initial track surface and define the first test build as a minimal playable mixed-reality demonstration: retain the existing Mixed Reality template XR foundation; use a simple placeholder buggy with basic Rigidbody movement and steering; provide a small simple tabletop track or test area; prioritise getting a build onto Meta Quest 3 for an initial passthrough and driving test.
- Explicit exclusions: No AI opponents, polished buggy model, race progression, lap system, menus, audio, multiplayer, advanced vehicle simulation or extra packages in this change.
- Files in scope: PROJECT_SPEC.md, CHANGE_REGISTER.md, MANIFEST.md and the minimum local Unity scene/scripts/assets strictly necessary for this test prototype. Do not replace or unnecessarily modify the template XR setup.
- Preserved functions: Carry forward all existing Mixed Reality template objects and settings unless a specific incompatibility is found and approved. Preserve FIXED project requirements.
- Checks planned: Inspect created scripts and scene setup; compile in Unity; attempt Android build and Quest test only when user confirms headset connection and build access. Distinguish any checks not run.
- Version transition: 0.6 -> 0.7 (change logged; implementation not yet started).
- Implementation step 1 authorised by user: add one self-contained script at `Assets/Scripts/MinimalTabletopDemo.cs`. It will generate a small tabletop test board, simple primitive buggy and cones at runtime; use Unity XR device input (left primary joystick for steering, right trigger for throttle, left trigger for brake) and Rigidbody movement. It will not modify the existing XR rig, add packages, or create race/AI features.
- Placement limitation for this first script: place the test board at a fixed offset in front of the headset camera, approximately table height; no plane detection or hand/controller placement is included.
- User instruction: proceed with the simplest test project.
- Implementation step 1 result: created `Assets/Scripts/MinimalTabletopDemo.cs` in the repository. Git blob SHA: `0cfb4dfb2d3be07efc700346ca1ed7ebaa9de1ea`.
- Script behaviour: generates a small board, low perimeter rails, four orange markers and a blue primitive buggy at runtime relative to the headset camera; reads XR left-hand primary 2D axis for steering, right trigger for acceleration and left trigger for braking; applies basic Rigidbody force and yaw torque.
- Files changed in this step: `Assets/Scripts/MinimalTabletopDemo.cs` created in GitHub. No local Unity project files have been edited or imported yet.
- Preserved functions: Existing Mixed Reality template scene and XR objects untouched; no packages added.
- Checks: Source file fetched back from GitHub and content length verified (8,351 characters). Code has not been compiled in Unity. No Android build, Quest deployment or runtime test performed.
- Known limitation: The board is positioned at a fixed offset relative to the headset camera and approximates tabletop height; it does not detect the physical table or support repositioning. Physical alignment and controller input mapping must be tested on device.



### RC-CHG-0007
- Status: COMPLETED - SCREENSHOT VERIFIED
- Request: Diagnose why the user reported that the script was not visible as a component on XR Origin.
- Scope: Screenshot inspection showed `Minimal Tabletop Demo (Script)` attached more than once to XR Origin. Retain exactly one enabled component.
- Files: User removed the duplicate component from the local Unity scene. No source files or repository source files changed.
- Preserved functions: Existing XR Origin, template components and one enabled MinimalTabletopDemo component with default settings preserved.
- Checks: Latest screenshot inspected; exactly one `Minimal Tabletop Demo (Script)` component is visible on XR Origin.
- Tests: Unity compilation, Android build, Quest deployment and runtime driving remain untested. Console status not shown in this screenshot.
- Issues: None observed in the Inspector. Compile status remains unverified.
- Version transition: 0.9 -> 1.0.

## Version history
- 0.1: Initial governance baseline.
- 0.2: Installed Unity Editor versions recorded.
- 0.3: Android modules confirmed for Unity 6.3 LTS.
- 0.4: Unity 6.3 LTS fixed as project editor.
- 0.5: RC-CHG-0005 logs initial local Unity project creation; completion pending.
- 0.6: RC-CHG-0005 completed after screenshot confirmation; RC-CHG-0006 logs the tabletop minimum-test prototype before implementation.
