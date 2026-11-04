# Change Register
Project: Meta Quest 3 Mixed Reality RC Racing
Version: 0.5
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

## Version history
- 0.1: Initial governance baseline.
- 0.2: Installed Unity Editor versions recorded.
- 0.3: Android modules confirmed for Unity 6.3 LTS.
- 0.4: Unity 6.3 LTS fixed as project editor.
- 0.5: RC-CHG-0005 logs initial local Unity project creation; completion pending.
