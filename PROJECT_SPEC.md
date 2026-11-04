# Meta Quest 3 Mixed Reality RC Racing
Project Specification
Version: 0.5
Status: DEVELOPMENT
Date: 2026-11-04

## 1. Purpose
Create a rapid, playable proof-of-concept mixed reality RC buggy racing experience for Meta Quest 3. The immediate goal is to demonstrate the concept, not to deliver a finished commercial game.

## 2. Requirements register

### FIXED
- Target headset: Meta Quest 3.
- Experience: mixed reality using the headset's passthrough view.
- Vehicle concept: realistic-looking remote-control buggy, not a slot car.
- Driving: player must be able to steer and control the buggy freely. The vehicle must not be constrained to a rail or fixed path.
- Prototype priority: quickest practical route to a playable concept demonstration.
- Initial track surface: tabletop.
- Unity Editor: Unity 6.3 LTS (6000.3.26f1), installed at `C:\\Program Files\\Unity\\Hub\\Editor\\6000.3.26f1\\Editor\\Unity.exe`.
- Android Build Support, Android SDK & NDK Tools, and OpenJDK are installed for the selected Unity 6.3 LTS editor, as confirmed by the user.

### PROPOSED (not yet approved as final implementation details)
- First test milestone: a minimal passthrough tabletop test area with a simple placeholder buggy using basic Rigidbody movement and steering, targeting an initial Meta Quest 3 build.
- Retain the existing Mixed Reality template XR foundation; avoid replacing template XR objects or adding packages unless required.
- Engine and toolchain: Unity.
- One player-controlled buggy and two AI opponents.
- A compact off-road circuit positioned in the user's real environment.
- Basic vehicle physics using Unity Rigidbody and wheel/vehicle components.
- AI opponents following waypoints around the circuit.
- Basic lap counter and race timer.
- Initial input via Quest controllers/joystick.

### UNRESOLVED
- Exact tabletop dimensions, placement/reposition method and buggy scale.
- Exact controller mapping and driving camera/view.
- Track dimensions, buggy scale and race format.
- Whether the first demonstration needs sound, menus, start lights or a reset/reposition interaction.
- Installation of Android build modules for Unity 6.6 is unconfirmed; this is not required for the selected editor.

## 3. Scope boundary for first proof of concept
The first test milestone is deliberately minimal: enter passthrough, use a small tabletop test area, and drive a simple free-steering placeholder buggy. AI opponents, race features and polish are deferred. Further features require a logged change and approval.

## 4. Non-goals for the first milestone
- Finished game polish or store release.
- Multiplayer/network racing.
- Advanced damage, tuning, progression or economy systems.
- Detailed simulation of a specific real-world buggy model.

## 5. Technical constraints
- Target hardware is Meta Quest 3.
- Prioritise a short build path and a reliable on-device demonstration.
- Selected editor is Unity 6.3 LTS (6000.3.26f1), with Android Build Support, Android SDK & NDK Tools and OpenJDK confirmed installed by the user.
- Do not assume unconfirmed Unity packages, APIs or SDK versions.

## 6. Acceptance criteria for the initial prototype (PROPOSED)
- Application launches on Meta Quest 3.
- Passthrough is visible.
- A tabletop test area can be viewed in passthrough.
- The player can accelerate, brake and steer a free-moving placeholder buggy.

These criteria remain PROPOSED until the user approves the detailed prototype scope.

## 7. Change control
All changes must be recorded in CHANGE_REGISTER.md before editing. Version and manifest updates are required after each documented change. Unchanged files must be carried forward byte-for-byte and identified as such. Do not claim tests that were not run.

## Version history
- 0.1: Initial governance and requirements baseline.
- 0.2: Recorded installed Unity Editor versions; editor selection and Android build module availability remained unresolved.
- 0.3: Recorded user-confirmed Android development module installation for Unity 6.3 LTS; editor selection remained unresolved.
- 0.4: Fixed Unity 6.3 LTS (6000.3.26f1) as the project editor.
- 0.5: Fixed tabletop as the initial track surface and defined a minimal placeholder-buggy test milestone; detailed dimensions and placement interaction remain unresolved.
