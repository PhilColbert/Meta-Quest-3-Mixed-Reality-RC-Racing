# Meta Quest 3 Mixed Reality RC Racing
Project Specification
Version: 0.1
Status: INITIAL BASELINE / DEVELOPMENT
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
- Exact Unity Editor version and installed Android/Quest build modules.
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
- Confirm the installed Unity version and Android build support before creating implementation files.
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
