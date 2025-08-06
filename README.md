# Flying Cubes 🐦

A Unity-based Augmented Reality (AR) game where players can spawn and interact with flying cube birds in real-world space.

## 🎮 Game Overview

Flying Cubes is an AR experience that allows users to spawn animated cube birds that fly upward in augmented reality. The game features two types of birds:

- **Mama Bird**: Flies upward while always facing the camera
- **Baby Bird**: Follows a randomly selected Mama Bird

## 🚀 Features

- **AR Integration**: Built with Unity's XR framework for augmented reality
- **Interactive Spawning**: Tap anywhere in AR space to spawn birds
- **Dual Bird Types**: Toggle between Mama and Baby bird spawning
- **Dynamic Movement**: Birds have realistic flight patterns and camera-following behavior
- **Mobile Ready**: Includes APK build for Android devices

## 🛠️ Technical Details

### Unity Version
- **Unity**: 2021.2.7f1
- **Platform**: Android (AR Core compatible)

### Core Scripts

#### `MamaBird.cs`
- Controls Mama Bird movement and rotation
- Birds fly upward at constant speed
- Always rotates to face the camera
- Configurable speed and rotation damping

#### `BabyBird.cs`
- Controls Baby Bird following behavior
- Randomly selects a Mama Bird to follow
- Smooth movement towards target Mama Bird
- Matching rotation and speed parameters

#### `ComponentManager.cs`
- Handles user input and bird spawning
- Toggle between Mama and Baby bird types
- Raycast-based AR interaction
- UI collision detection

### Project Structure
```
Bird Family/
├── Assets/
│   ├── Scripts/          # Core game logic
│   ├── Scenes/           # Main game scene
│   ├── Prefabs/          # Bird prefabs
│   ├── Materials/         # Bird materials
│   ├── Texture/          # Background textures
│   └── XR/              # AR/XR settings
├── ProjectSettings/       # Unity project configuration
└── Packages/            # Unity packages
```

## 📱 Installation & Setup

### Prerequisites
- Unity 2021.2.7f1 or compatible version
- Android device with AR Core support
- Android SDK and build tools

### Building for Android
1. Open the project in Unity
2. Ensure AR Core package is installed
3. Configure build settings for Android
4. Build APK for deployment

### Running the Game
1. Install the APK on an AR Core compatible Android device
2. Grant camera permissions when prompted
3. Point camera at a flat surface
4. Tap to spawn birds!

## 🎯 How to Play

1. **Launch the AR app** on your Android device
2. **Point your camera** at a flat surface
3. **Toggle bird type** using the UI button
4. **Tap anywhere** in AR space to spawn birds
5. **Watch the birds fly** and interact with each other

## 🎨 Visual Style

- **Minimalist Design**: Simple cube-based bird models
- **Color-coded Birds**: Different materials for Mama and Baby birds
- **AR Integration**: Birds appear in real-world space
- **Smooth Animations**: Fluid movement and rotation

## 🔧 Development

### Key Components
- **AR Camera**: Main camera for AR tracking
- **Bird Prefabs**: Reusable bird objects with scripts
- **UI System**: Toggle for bird type selection
- **Physics System**: Rigidbody-based movement

### Customization
- Adjust bird speed in script parameters
- Modify rotation damping for smoother movement
- Change bird materials for visual customization
- Add new bird types by extending the script system

## 📄 License

This project is open source. Feel free to modify and distribute according to your needs.

## 🤝 Contributing

Contributions are welcome! Please feel free to submit pull requests or open issues for bugs and feature requests.

---

**Note**: This project requires AR Core support and is designed for Android devices. Make sure your device supports AR Core for the best experience.