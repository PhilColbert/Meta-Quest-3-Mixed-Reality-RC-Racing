# Change Register
Project: Meta Quest 3 Mixed Reality RC Racing
Version: 0.1
Status: INITIAL BASELINE
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
- Status: LOGGED BEFORE EDIT
- Request: Record the user's installed Unity Editor versions supplied while continuing project setup.
- Scope: Update PROJECT_SPEC.md with the two installed editor versions and executable paths; keep editor selection and Android build module availability UNRESOLVED. Update this register and MANIFEST.md to project version 0.2.
- Explicit exclusions: No Unity editor selection, project creation, packages, source code, assets or implementation.
- Files in scope: PROJECT_SPEC.md, CHANGE_REGISTER.md, MANIFEST.md.
- Preserved functions: No application functions exist yet. All existing project requirements and scope are to be preserved.
- Checks planned: Fetch and verify all three updated records and their Git blob SHAs after saving.
- Version transition: 0.1 -> 0.2.

## Version history
- 0.1: Initial project specification, change register and release manifest created. No application source created.
- 0.2: RC-CHG-0002 records the installed Unity Editor versions; editor selection and Android module availability remain unresolved.
