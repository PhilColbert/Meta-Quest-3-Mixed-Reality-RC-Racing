# Release Manifest
Project: Meta Quest 3 Mixed Reality RC Racing
Manifest version: 1.0
Project baseline: 1.0
Release state: DEVELOPMENT
Date: 2026-11-04
Default branch: main
Repository: https://github.com/PhilColbert/Meta-Quest-3-Mixed-Reality-RC-Racing

## Current baseline files
| Path | Project version | Git blob SHA | State |
|---|---:|---|---|
| PROJECT_SPEC.md | 0.5 | 228eec871989bcdb86fe62bf1215bcf8dde8b906 | CARRIED FORWARD BYTE-FOR-BYTE |
| CHANGE_REGISTER.md | 1.0 | d6e4cd84bebc081b5570ff6a8a5b7f1fb1627030 | UPDATED: RC-CHG-0007 completed |
| MANIFEST.md | 1.0 | PENDING SELF-VERIFICATION AFTER COMMIT | UPDATED |
| Assets/Scripts/MinimalTabletopDemo.cs | 0.1 prototype source | 0cfb4dfb2d3be07efc700346ca1ed7ebaa9de1ea | CREATED; local import visually confirmed |

## Implementation status
- User imported MinimalTabletopDemo.cs into Assets/Scripts.
- Screenshot inspection confirms exactly one enabled Minimal Tabletop Demo (Script) component on XR Origin after duplicate cleanup.
- Existing Mixed Reality template XR objects remain present.
- No source code changed during duplicate cleanup.
- The script generates a miniature board, perimeter rails, four markers and a simple primitive buggy at runtime relative to Camera.main.
- Controls in script: left primary 2D axis steers; right trigger accelerates; left trigger brakes.
- No compile, Android build, Quest deployment or runtime driving test has been performed.

## Verification record
- Dedicated repository access and permissions verified previously.
- PROJECT_SPEC.md carried forward byte-for-byte at version 0.5; SHA 228eec871989bcdb86fe62bf1215bcf8dde8b906.
- Source script exists at Assets/Scripts/MinimalTabletopDemo.cs; SHA 0cfb4dfb2d3be07efc700346ca1ed7ebaa9de1ea.
- RC-CHG-0007 completed based on latest screenshot: exactly one enabled MinimalTabletopDemo component visible in XR Origin Inspector.
- Console status is not visible in the latest screenshot; compile status remains unverified.
- Exact local Unity project path and full local file inventory remain unverified.

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
- 0.5: Tabletop minimum-test scope recorded.
- 0.6: Initial Unity project creation confirmed.
- 0.7: Tabletop prototype scope logged.
- 0.8: First script and controls logged before source creation.
- 0.9: Added minimal tabletop demo script; local import pending.
- 1.0: RC-CHG-0007 duplicate component cleanup completed and screenshot verified.
