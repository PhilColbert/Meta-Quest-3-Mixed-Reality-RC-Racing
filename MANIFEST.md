# Release Manifest
Project: Meta Quest 3 Mixed Reality RC Racing
Manifest version: 0.7
Project baseline: 0.7
Release state: DEVELOPMENT
Date: 2026-11-04
Default branch: main
Repository: https://github.com/PhilColbert/Meta-Quest-3-Mixed-Reality-RC-Racing

## Current baseline files
| Path | Project version | Git blob SHA | State |
|---|---:|---|---|
| PROJECT_SPEC.md | 0.5 | 228eec871989bcdb86fe62bf1215bcf8dde8b906 | UPDATED: tabletop and minimum test scope |
| CHANGE_REGISTER.md | 0.7 | f085440af25f6c8d33352e728d2f1ea462fdbac0 | UPDATED: RC-CHG-0005 completion and RC-CHG-0006 logged |
| MANIFEST.md | 0.7 | PENDING SELF-VERIFICATION AFTER COMMIT | UPDATED |

## Previous baseline
| Path | Project version | Previous Git blob SHA |
|---|---:|---|
| PROJECT_SPEC.md | 0.4 | 155a18d1f87a7bfe20c0b18c8fce45a436680b40 |
| CHANGE_REGISTER.md | 0.5 | d8407df64e083f856f394f905d16850d370c0aaa |
| MANIFEST.md | 0.5 | 9d6e46fc0058d57120e359ac795c7fe1d827c2ee |

## Implementation files
The local Unity project RC Buggy MR Racing was confirmed open in Unity Editor from the user's screenshot. Exact local path and generated file inventory have not been captured. No project implementation files are tracked in this GitHub repository.

## Verification record
- Dedicated repository identity and access were verified previously; default branch main; push and admin permissions confirmed.
- RC-CHG-0005 completion is based on the screenshot showing the Unity Editor open with the Mixed Reality template scene. Exact local path and file inventory remain unverified.
- RC-CHG-0006 was logged before implementation. It fixes tabletop as the initial track surface and scopes the first test to passthrough plus a simple placeholder buggy with basic free steering and Rigidbody movement.
- Existing template XR foundation is to be preserved; no changes to the Unity scene or source files have yet been made.
- No Unity compile, Android build, Quest deployment, headset or runtime test has been performed.
- PROJECT_SPEC.md changed from 0.4 to 0.5 for tabletop and minimum-test scope.
- CHANGE_REGISTER.md updated to 0.7 for RC-CHG-0005 completion and RC-CHG-0006 logging.

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
