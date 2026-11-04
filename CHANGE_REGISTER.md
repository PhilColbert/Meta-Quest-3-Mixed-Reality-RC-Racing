# Change Register
Project: Meta Quest 3 Mixed Reality RC Racing
Version: 0.3
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
- Version transition: 0.0 (empty repository) -> 0.1 (initial governance baseline).
- Next step: Confirm Unity Editor version and Android build support, then resolve the minimum prototype choices before implementation.

### RC-CHG-0002
- Status: RECORDED
- Request: Record the user's installed Unity Editor versions supplied while continuing project setup.
- Scope: Update PROJECT_SPEC.md with the two installed editor versions and executable paths; keep editor selection and Android build module availability UNRESOLVED. Update this register and MANIFEST.md to project version 0.2.
- Explicit exclusions: No Unity editor selection, project creation, packages, source code, assets or implementation.
- Files changed: PROJECT_SPEC.md, CHANGE_REGISTER.md, MANIFEST.md.
- Preserved functions: No application functions existed. All existing project requirements and scope were preserved.
- Checks: All three governance files fetched after saving. PROJECT_SPEC.md SHA d9f9a71a9ddc9d304cca6df9eedf8014c7ffefbf; CHANGE_REGISTER.md SHA 8991433d472975c1eb30f29c1660cd1339230eed; MANIFEST.md SHA 38d2f8bad4619f96570cd9aa1e58502dd9cec7cc.
- Results: Both installed editor versions and paths recorded.
- Issues/deviations: No Unity build, editor validation or headset test performed.
- Version transition: 0.1 -> 0.2.

### RC-CHG-0003
- Status: LOGGED BEFORE EDIT
- Request: Record the user's confirmation that the Android development modules have been installed for Unity 6.3 LTS (6000.3.26f1).
- Scope: Update PROJECT_SPEC.md to record Android Build Support, Android SDK & NDK Tools, and OpenJDK as installed for Unity 6.3 LTS, based on user confirmation. Keep Unity Editor selection UNRESOLVED pending explicit confirmation. Update this register and MANIFEST.md to project version 0.3.
- Explicit exclusions: Do not select an editor on the user's behalf; do not create a Unity project or implementation/source/assets/packages/build configuration.
- Files in scope: PROJECT_SPEC.md, CHANGE_REGISTER.md, MANIFEST.md.
- Preserved functions: No application functions exist. Preserve all existing FIXED requirements, proposals, unresolved decisions and scope boundaries.
- Checks planned: Fetch all three governance files after saving and verify content and Git blob SHAs. No Unity build or headset test is claimed.
- Version transition: 0.2 -> 0.3.

## Version history
- 0.1: Initial project specification, change register and release manifest created. No application source created.
- 0.2: RC-CHG-0002 records the installed Unity Editor versions.
- 0.3: RC-CHG-0003 records user-confirmed Android development module installation for Unity 6.3 LTS; editor selection remains unresolved.
