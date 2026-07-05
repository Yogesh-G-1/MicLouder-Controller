# Quick Setup Guide

## Step-by-Step Setup

### Step 1: Clone the Repository

```bash
git clone https://github.com/Yogesh-G-1/MicLouder-Controller.git
cd MicLouder-Controller
```

### Step 2: Copy MicLouder DLL

1. Compile `MicLouder.cpp` to get `MicLouder_x64.dll`
2. Copy the DLL to the project folder:
   ```
   MicLouder-Controller/MicLouder_x64.dll
   ```

### Step 3: Open in Visual Studio

1. Open Visual Studio 2022
2. File → Open → Folder → Select MicLouder-Controller folder
3. Wait for Visual Studio to load the project

### Step 4: Configure Platform

1. Build → Configuration Manager
2. Set Platform to **x64**
3. Click Close

### Step 5: Build

```bash
Ctrl+Shift+B  # Build the solution
```

You should see: "Build succeeded"

### Step 6: Run

```bash
F5  # Start the application
```

### Step 7: Use the Application

The console window will open with a menu. Select options 1-7 to control your microphone.

---

## Troubleshooting

### Issue: "'cl' is not recognized"
**Solution**: Use Visual Studio's built-in compile tools, not command line `cl` compiler

### Issue: DLL not found
**Solution**: Make sure `MicLouder_x64.dll` is in the project folder alongside `Program.cs`

### Issue: Build fails for x64
**Solution**: Go to Build → Configuration Manager and ensure Platform is set to x64

### Issue: Microphone not initializing
**Solution**: 
- Check Windows audio settings
- Verify microphone is enabled and working
- Try disconnecting and reconnecting the microphone

---

## File Locations

After setup, your folder should look like:

```
MicLouder-Controller/
├── Program.cs                          # Main application
├── MicrophoneController.csproj         # Project file
├── App.config                          # Configuration
├── MicLouder_x64.dll                  # DLL (copy here)
├── README.md                           # Documentation
├── SETUP.md                            # This file
├── bin/
│   └── x64/
│       ├── Debug/
│       └── Release/
└── obj/
```

---

## Next Steps

1. Run the application
2. Use option 4 (2.0x) as default
3. Adjust as needed for Discord
4. Keep volume under 3.0x for best audio quality
