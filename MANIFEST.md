# Release Manifest
Project: Meta Quest 3 Mixed Reality RC Racing
Manifest version: 0.9
Project baseline: 0.9
Release state: DEVELOPMENT
Date: 2026-11-04
Default branch: main
Repository: https://github.com/PhilColbert/Meta-Quest-3-Mixed-Reality-RC-Racing

## Current baseline files
| Path | Project version | Git blob SHA | State |
|---|---:|---|---|
| PROJECT_SPEC.md | 0.5 | 228eec871989bcdb86fe62bf1215bcf8dde8b906 | CARRIED FORWARD BYTE-FOR-BYTE FROM 0.5 |
| CHANGE_REGISTER.md | 0.9 | c8397a2008bbac68c1e8c82a7fc9144b7fdcbbe0 | UPDATED: RC-CHG-0006 implementation step 1 recorded |
| MANIFEST.md | 0.9 | PENDING SELF-VERIFICATION AFTER COMMIT | UPDATED |
| Assets/Scripts/MinimalTabletopDemo.cs | 0.1 prototype source | 0cfb4dfb2d3be07efc700346ca1ed7ebaa9de1ea | CREATED; NOT YET IMPORTED INTO LOCAL UNITY PROJECT |

## Previous baseline
| Path | Project version | Previous Git blob SHA |
|---|---:|---|
| PROJECT_SPEC.md | 0.5 | 228eec871989bcdb86fe62bf1215bcf8dde8b906 |
| CHANGE_REGISTER.md | 0.8 | 7b656b13c8f114d55baedc02fa64e5182956af86 |
| MANIFEST.md | 0.7 | 1eeae8bf39e0ff7ec2246e705314858e7ec26995 |

## Implementation status
- The local Unity project RC Buggy MR Racing was confirmed open in Unity Editor by user screenshot.
- The canonical first prototype script has been created in the GitHub repository at Assets/Scripts/MinimalTabletopDemo.cs.
- The script generates a miniature tabletop board, perimeter rails, four orange markers and a simple blue primitive buggy at runtime relative to Camera.main.
- Input mapping in the script: left controller primary 2D axis steers; right controller trigger accelerates; left controller trigger brakes.
- Movement uses basic Rigidbody force and yaw torque.
- The script is not yet copied into the user's local Unity project and is not attached to XR Origin.
- Existing Mixed Reality template scene and XR objects have not been modified. No new packages have been added.

## Verification record
- Dedicated repository and user access were verified previously; default branch main; push and admin permissions confirmed.
- RC-CHG-0005 completion is based on screenshot showing the Unity Editor open. Exact local project path and file inventory remain unverified.
- RC-CHG-0006 was logged before implementation. The first script was created only after the user said to proceed.
- Script file was fetched back from GitHub; its Git blob SHA is recorded above. Source inspection only; not compiled.
- Fixed-offset placement approximates tabletop height but does not detect the physical table or allow repositioning.
- No Unity compile, Android build, Quest deployment, headset test or runtime driving test has been performed.
- PROJECT_SPEC.md is carried forward byte-for-byte from version 0.5; no requirement changes in this implementation step.

## Release rules
- Update this manifest whenever a tracked project file changes.
- Record exact file paths, project versions and Git blob SHAs.
- Do not describe a file as tested unless the corresponding test was actually run.
- User approval is required before a development candidate is considered approved.

## Version history
- 0.1: Initial project governance baseline.
- 0.2: Installed Unity Editor versions recorded.
- 0.3: Android modules confirmed for Unity 6.3 LTS.
- 0.4: Unity 6.3 LTS fixed as project editor.
- 0.5: RC-CHG-0005 logs initial local Unity project creation.
- 0.6: RC-CHG-0005 completed after screenshot confirmation.
- 0.7: RC-CHG-0006 logs tabletop minimum-test prototype scope before implementation.
- 0.8: RC-CHG-0006 records exact first script and controls before source creation.
- 0.9: Added the first minimal tabletop demo script; local import and testing pending.
