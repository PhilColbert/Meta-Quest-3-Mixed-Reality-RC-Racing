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
| PROJECT_SPEC.md | 0.5 | 228eec871989bcdb86fe62bf1215bcf8dde8b906 | CARRIED FORWARD BYTE-FOR-BYTE FROM 0.5 |
| CHANGE_REGISTER.md | 1.0 | 841b80b1a105858ae7e64bc2dc5bb98dc8bfb20a | UPDATED: RC-CHG-0007 duplicate component cleanup logged |
| MANIFEST.md | 1.0 | PENDING SELF-VERIFICATION AFTER COMMIT | UPDATED |
| Assets/Scripts/MinimalTabletopDemo.cs | 0.1 prototype source | 0cfb4dfb2d3be07efc700346ca1ed7ebaa9de1ea | CREATED; source fetched and inspected; Unity compile not verified |

## Implementation status
- User imported MinimalTabletopDemo.cs into Assets/Scripts.
- Latest screenshot shows the XR Origin Inspector displaying multiple Minimal Tabletop Demo (Script) component instances. RC-CHG-0007 logs retaining exactly one enabled instance and removing duplicates.
- Existing Mixed Reality template XR objects remain present.
- No source code has been changed in this cleanup.
- No Unity compile, Android build, Quest deployment or runtime driving test has been performed.

## Verification record
- Dedicated repository access and permissions verified previously.
- PROJECT_SPEC.md remains byte-for-byte unchanged at version 0.5.
- Source script exists at Assets/Scripts/MinimalTabletopDemo.cs with SHA 0cfb4dfb2d3be07efc700346ca1ed7ebaa9de1ea.
- Screenshot inspection confirms script components are visible on XR Origin; the screenshot shows duplicate instances.
- Console screenshot shows no visible messages, but no explicit compile validation has been performed.
- Exact local Unity project path and local file inventory remain unverified.

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
- 0.9: Added the minimal tabletop demo script; local import pending.
- 1.0: RC-CHG-0007 logs cleanup of duplicate component attachments.
