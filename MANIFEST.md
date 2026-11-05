# Release Manifest
Project: Meta Quest 3 Mixed Reality RC Racing
Manifest version: 1.1
Project baseline: 1.2
Release state: DEVELOPMENT
Date: 2026-11-05
Default branch: main
Repository: https://github.com/PhilColbert/Meta-Quest-3-Mixed-Reality-RC-Racing

## Current baseline files
| Path | Project version | Git blob SHA | State |
|---|---:|---|---|
| PROJECT_SPEC.md | 0.5 | 228eec871989bcdb86fe62bf1215bcf8dde8b906 | CARRIED FORWARD BYTE-FOR-BYTE |
| CHANGE_REGISTER.md | 1.2 | 53cf4e5e9c4937f3f3585bdfa0d9908ed578560d | UPDATED: RC-CHG-0008 Standalone XR settings result recorded |
| MANIFEST.md | 1.1 | PENDING SELF-VERIFICATION AFTER COMMIT | UPDATED |
| Assets/Scripts/MinimalTabletopDemo.cs | 0.1 prototype source | 0cfb4dfb2d3be07efc700346ca1ed7ebaa9de1ea | CARRIED FORWARD BYTE-FOR-BYTE; no source edit in RC-CHG-0008 |

## Unity configuration status
- User screenshot confirms Standalone XR Plug-in Management: OpenXR enabled; Meta Quest feature group enabled; Initialize XR on Startup enabled; XR Simulation disabled; Mock HMD disabled.
- User screenshot of OpenXR settings shows Oculus Touch Controller Profile and Meta Quest Touch Plus Controller Profile listed.
- Meta Horizon Link OpenXR runtime action is greyed out in the user's General settings screen, consistent with Link already being the active runtime.
- The user reports Meta Horizon Link is connected.
- Meta Horizon Link Settings screenshot shows Account and General tabs only; no Developer or Beta tab is visible. Access to Developer Runtime Features and Passthrough over Meta Horizon Link remains unresolved pending confirmation of Quest Developer Mode/account status and available Meta app features.
- Exact local Unity project path and on-disk Unity settings file paths/checksums have not been captured; no local configuration file checksum is asserted.
- Android-target settings were not intentionally changed in this change.
- NVIDIA driver warning banner is visible in Meta Horizon Link; no driver modification performed.

## Implementation status
- User imported MinimalTabletopDemo.cs into Assets/Scripts.
- Screenshot inspection confirms exactly one enabled Minimal Tabletop Demo (Script) component on XR Origin.
- Existing Mixed Reality template XR objects remain present.
- Source script remains unchanged from Git blob SHA 0cfb4dfb2d3be07efc700346ca1ed7ebaa9de1ea.
- Script generates a miniature board, perimeter rails, four markers and a simple primitive buggy at runtime relative to Camera.main.
- Controls in script: left primary 2D axis steers; right trigger accelerates; left trigger brakes.
- No Unity compilation, Android build, Quest deployment or runtime driving test has been performed.
- The Editor-to-headset Play test after enabling Standalone OpenXR has not yet been confirmed.

## Verification record
- Dedicated repository access and permissions verified previously.
- PROJECT_SPEC.md is carried forward byte-for-byte at version 0.5; SHA 228eec871989bcdb86fe62bf1215bcf8dde8b906.
- CHANGE_REGISTER.md fetched back at version 1.2 before this manifest update; SHA 53cf4e5e9c4937f3f3585bdfa0d9908ed578560d.
- Source script fetched previously and unchanged during RC-CHG-0008; SHA 0cfb4dfb2d3be07efc700346ca1ed7ebaa9de1ea.
- Unity settings are screenshot-inspected only; no compiled/build/runtime test is implied.
- Exact local Unity project path, complete local file inventory, and local ProjectSettings file checksums remain unverified.

## Release rules
- Update this manifest whenever a tracked project file changes.
- Record exact file paths, project versions and Git blob SHAs when available.
- Do not describe a file as tested unless the corresponding test was actually run.
- User approval is required before a development candidate is considered approved.

## Version history
- 1.1: RC-CHG-0008 Standalone OpenXR configuration was screenshot-verified; Meta Link developer passthrough and runtime test remain pending.
- 1.0: RC-CHG-0007 duplicate component cleanup completed and screenshot verified.
- 0.9: Added minimal tabletop demo script; local import pending.
- 0.8: First script and controls logged before source creation.
- 0.7: Tabletop prototype scope logged.
- 0.6: Initial Unity project creation confirmed.
- 0.5: Tabletop minimum-test scope recorded.
- 0.4: Unity 6.3 LTS fixed as project editor.
- 0.3: Android modules confirmed for Unity 6.3 LTS.
- 0.2: Installed Unity Editor versions recorded.
- 0.1: Initial project governance baseline.
