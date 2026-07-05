# MicLouder Controller - Usage Guide

## Starting the Application

1. Open Visual Studio
2. Press **F5** to run the application
3. A console window will open with the main menu

## Main Menu

```
╔════════════════════════════════════════╗
║        MICROPHONE CONTROL              ║
╚════════════════════════════════════════╝
1. Get current volume
2. Set custom volume
3. Preset: 1.5x (slightly louder)
4. Preset: 2.0x (moderately louder)
5. Preset: 2.5x (much louder)
6. Preset: 3.0x (very loud)
7. Deactivate microphone
0. Exit
```

## Options Explained

### 1. Get Current Volume
Shows the current microphone amplification level.
```
✓ Current volume: 2.0x
```

### 2. Set Custom Volume
Allows you to enter a specific volume multiplier (0.1 - 10.0).
```
Enter volume (0.1 - 10.0): 2.5
✓ Set to 2.5x
```

### 3-6. Preset Volume Levels
Quickly set to predefined volume levels:
- **1.5x** - Slightly louder (quiet environments)
- **2.0x** - Moderately louder (standard, default)
- **2.5x** - Much louder (noisy environments)
- **3.0x** - Very loud (extreme amplification)

### 7. Deactivate Microphone
Stops audio amplification and cleans up resources.
```
✓ Microphone deactivated
```

### 0. Exit
Closes the application and deactivates the microphone.
```
Goodbye!
```

---

## Volume Level Guide

| Multiplier | Effect | Use Case | Audio Quality |
|-----------|--------|----------|---------------|
| 1.0 | No amplification | Baseline | Perfect |
| 1.5 | Slightly louder | Quiet room | Excellent |
| 2.0 | Moderately louder | Standard (default) | Excellent |
| 2.5 | Much louder | Noisy room | Good |
| 3.0 | Very loud | Extreme cases | Fair |
| 3.0+ | Extreme | Not recommended | Poor/Distorted |

---

## Using with Discord

### Step 1: Run MicLouder Controller
1. Start this application
2. Set your desired volume (e.g., option 4 for 2.0x)
3. Leave it running

### Step 2: Configure Discord
1. Open Discord
2. Go to **User Settings** → **Voice & Video**
3. Select your microphone input
4. Adjust Discord's input volume if needed
5. Join a voice channel

### Step 3: Test Audio
1. Ask a friend to listen to your microphone audio
2. Adjust volume in MicLouder Controller if needed
3. Once satisfied, leave it running during your call

---

## Tips for Best Results

### Optimal Settings
- **Default:** 2.0x (good balance of volume and clarity)
- **Noisy environment:** 2.5x (helps overcome background noise)
- **Quiet environment:** 1.5x (avoids over-amplification)

### Audio Quality
- Keep volume **below 3.0x** to maintain audio quality
- Higher amplification increases noise along with volume
- Test with different levels to find your sweet spot

### Discord Optimization
- Set Discord's input volume to 100%
- Use MicLouder Controller to fine-tune amplification
- Enable noise suppression in Discord if available

### Troubleshooting Audio Issues
- **Too quiet?** Gradually increase volume (2.0x → 2.5x → 3.0x)
- **Too loud/distorted?** Decrease volume (3.0x → 2.5x → 2.0x)
- **Feedback/echo?** Make sure speakers aren't near microphone
- **Background noise?** Lower volume or use Discord's noise suppression

---

## Keyboard Shortcuts

| Action | Shortcut |
|--------|----------|
| Open menu | (automatic) |
| Select option | Type number (1-7, 0) + Enter |
| Go back to menu | Completes action → menu reappears |
| Exit application | Select 0 then Enter |

---

## Application Flow

```
Start Application
    ↓
Initialize Audio Device
    ↓
Set Default Volume (2.0x)
    ↓
Show Main Menu
    ↓
User Selects Option
    ↓
Execute Command
    ↓
(Loop back to menu)
    ↓
User Selects Exit (0)
    ↓
Cleanup Audio Device
    ↓
Exit Application
```

---

## Common Tasks

### Task: Set microphone to 2.5x louder
1. Press **5** in the menu
2. Application confirms: `✓ 2.5x`

### Task: Check current volume
1. Press **1** in the menu
2. Application shows: `✓ Current volume: 2.5x`

### Task: Set to 1.8x (custom)
1. Press **2** in the menu
2. Enter: `1.8`
3. Application confirms: `✓ Set to 1.8x`

### Task: Stop amplification
1. Press **7** in the menu
2. Application confirms: `✓ Microphone deactivated`

---

## Performance Notes

- **Memory usage:** ~50-100 MB
- **CPU usage:** Minimal (<1%)
- **Latency:** Real-time (no noticeable delay)
- **Compatibility:** Windows 10/11 x64 only

---

## Safety Warnings

⚠️ **Important:**
- Do not use volume above 3.0x continuously
- Monitor audio quality at higher volumes
- Avoid feedback loops (speakers near microphone)
- Take breaks during long voice calls
- Keep application running only when needed
