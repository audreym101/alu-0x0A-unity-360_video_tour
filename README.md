# ALU 0x0A Unity 360 Video Tour

A Unity-based interactive 360° video tour application featuring two tour experiences with smooth fade transitions between locations.

## Features

- 360° video playback using sphere-mapped render textures
- Smooth fade transitions between locations
- Interactive hotspot buttons for navigation
- Two tour experiences: Intranet Tour and Custom Campus Tour
- Main menu scene for tour selection

## Scenes

| Scene | Description |
|-------|-------------|
| `MainMenuScene` | Entry point with buttons to select a tour |
| `IntranetTour` | Indoor tour: Living Room, Cantina, Cube, Mezzanine |
| `CustomCampusTour` | Outdoor campus tour: Outside, Parking, Elevator |

## Scripts

| Script | Description |
|--------|-------------|
| `SceneLoader.cs` | Handles scene transitions between Main Menu, Intranet Tour, and Custom Campus Tour |
| `SwitchRooms.cs` | Manages sphere switching with fade transitions for the Intranet Tour |
| `CampusTourManager.cs` | Manages sphere switching with fade transitions for the Custom Campus Tour |
| `ScreenFader.cs` | Handles fade in/out effect using a UI Image |
| `CursorLook.cs` | Mouse look and raycast-based button interaction |
| `FlipNormals.cs` | Flips sphere normals so video renders on the inside |

## Setup

### Requirements
- Unity 2022.3 or above
- Universal Render Pipeline (URP)

### Build
1. Open project in Unity
2. Go to **File → Build Profiles**
3. Add all 3 scenes in order: `MainMenuScene`, `IntranetTour`, `CustomCampusTour`
4. Set platform to **Android**
5. Build to a folder outside `Assets/`

## Notes

- Video files must be re-encoded to a maximum resolution of `3840x1920` for Windows H264 decoder compatibility
- Each scene requires its own `SceneLoader` and `ScreenFader` GameObjects assigned in the Inspector
