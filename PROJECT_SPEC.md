# Meta Quest 3 Mixed Reality RC Racing
Project Specification
Version: 0.3
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

### PROPOSED (not yet approved as final implementation details)
- Engine and toolchain: Unity.
- One player-controlled buggy and two AI opponents.
- A compact off-road circuit positioned in the user's real environment.
- Basic vehicle physics using Unity Rigidbody and wheel/vehicle components.
- AI opponents following waypoints around the circuit.
- Basic lap counter and race timer.
- Initial input via Quest controllers/joystick.

### UNRESOLVED
- Track placement surface: table or floor.
- Unity Editor selection for this project. Installed versions reported: Unity 6.6 (6000.6.6f1) at `C:\\Program Files\\Unity\\Hub\\Editor\\6000.6.6f1\\Editor\\Unity.exe`, and Unity 6.3 LTS (6000.3.26f1) at `C:\\Program Files\\Unity\\Hub\\Editor\\6000.3.26f1\\Editor\\Unity.exe`. Android Build Support, Android SDK & NDK Tools, and OpenJDK have been installed for Unity 6.3 LTS, as confirmed by the user. Installation for Unity 6.6 has not been confirmed.
- Exact controller mapping and driving camera/view.
- Track dimensions, buggy scale and race format.
- Whether the first demonstration needs sound, menus, start lights or a reset/reposition interaction.

## 3. Scope boundary for first proof of concept
The first milestone is a simple end-to-end demonstration: enter passthrough, place or position a small track, drive a free-steering buggy, and observe at least one AI vehicle navigating the course. Further features require a logged change and approval.

## 4. Non-goals for the first milestone
- Finished game polish or store release.
- Multiplayer/network racing.
- Advanced damage, tuning, progression or economy systems.
- Detailed simulation of a specific real-world buggy model.

## 5. Technical constraints
- Target hardware is Meta Quest 3.
- Prioritise a short build path and a reliable on-device demonstration.
- Confirm Android build support and the selected editor version before creating implementation files.
- Do not assume unconfirmed Unity packages, APIs or SDK versions.

## 6. Acceptance criteria for the initial prototype (PROPOSED)
- Application launches on Meta Quest 3.
- Passthrough is visible.
- A virtual track can be positioned in the real environment.
- The player can accelerate, brake and steer a free-moving buggy.
- At least one AI buggy can navigate the track.
- A basic lap or elapsed-time indicator is visible.

These criteria remain PROPOSED until the user approves the detailed prototype scope.

## 7. Change control
All changes must be recorded in CHANGE_REGISTER.md before editing. Version and manifest updates are required after each documented change. Unchanged files must be carried forward byte-for-byte and identified as such. Do not claim tests that were not run.

## Version history
- 0.1: Initial governance and requirements baseline.
- 0.2: Recorded installed Unity Editor versions; editor selection and Android build module availability remained unresolved.
- 0.3: Recorded user-confirmed Android development module installation for Unity 6.3 LTS; editor selection remains unresolved.
