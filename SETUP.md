# MicLouder Controller - C# Application

A C# console application that controls the MicLouder microphone amplifier DLL for Discord.

## Features

✅ Initialize and control microphone amplification
✅ Preset volume levels (1.5x, 2.0x, 2.5x, 3.0x)
✅ Custom volume control (0.1 - 10.0x)
✅ Real-time volume adjustment
✅ Color-coded console output
✅ Error handling and validation

## Requirements

- Windows 10/11 (x64)
- .NET Framework 4.7.2 or higher
- Visual Studio 2022 Community (or Professional/Enterprise)
- MicLouder_x64.dll (compiled from MicLouder.cpp)

## Setup Instructions

### 1. Prepare Files

1. Create a folder: `C:\Users\DELL\MicrophoneController`
2. Copy these files into that folder:
   - `Program.cs`
   - `MicrophoneController.csproj`
   - `App.config`
3. Copy `MicLouder_x64.dll` from the compiled output folder into the same directory

### 2. Open in Visual Studio

1. Open Visual Studio 2022
2. File → Open → Folder
3. Select `C:\Users\DELL\MicrophoneController`
4. Visual Studio will automatically detect the project

### 3. Build the Project

```bash
Ctrl+Shift+B  # Build Solution
