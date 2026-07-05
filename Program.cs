using System;
using System.Runtime.InteropServices;

class MicrophoneController
{
    [DllImport("MicLouder_x64.dll")]
    public static extern int InitAudioDevice();
    
    [DllImport("MicLouder_x64.dll")]
    public static extern void SetVolumeMultiplier(float multiplier);
    
    [DllImport("MicLouder_x64.dll")]
    public static extern float GetVolumeMultiplier();
    
    [DllImport("MicLouder_x64.dll")]
    public static extern void CleanupAudioDevice();
    
    static bool isActive = false;
    
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("╔════════════════════════════════════════╗");
        Console.WriteLine("║   MicLouder - Microphone Amplifier     ║");
        Console.WriteLine("║          for Discord                    ║");
        Console.WriteLine("╚════════════════════════════════════════╝");
        Console.ResetColor();
        Console.WriteLine();
        
        Console.Write("Initializing audio device... ");
        int result = InitAudioDevice();
        
        if (result != 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"✗ Failed (Error: {result})");
            Console.ResetColor();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            return;
        }
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("✓ Success");
        Console.ResetColor();
        isActive = true;
        
        float defaultVolume = 2.0f;
        SetVolumeMultiplier(defaultVolume);
        Console.WriteLine($"Default volume: {defaultVolume}x\n");
        
        ShowMenu();
    }
    
    static void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("\n╔════════════════════════════════════════╗");
            Console.WriteLine("║        MICROPHONE CONTROL              ║");
            Console.WriteLine("╚════════════════════════════════════════╝");
            Console.WriteLine("1. Get current volume");
            Console.WriteLine("2. Set custom volume");
            Console.WriteLine("3. Preset: 1.5x (slightly louder)");
            Console.WriteLine("4. Preset: 2.0x (moderately louder)");
            Console.WriteLine("5. Preset: 2.5x (much louder)");
            Console.WriteLine("6. Preset: 3.0x (very loud)");
            Console.WriteLine("7. Deactivate microphone");
            Console.WriteLine("0. Exit");
            Console.WriteLine("╚════════════════════════════════════════╝");
            Console.Write("\nSelect: ");
            
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1": GetVolume(); break;
                case "2": SetCustomVolume(); break;
                case "3": SetPreset(1.5f, "1.5x"); break;
                case "4": SetPreset(2.0f, "2.0x"); break;
                case "5": SetPreset(2.5f, "2.5x"); break;
                case "6": SetPreset(3.0f, "3.0x"); break;
                case "7": Deactivate(); break;
                case "0": Exit(); return;
                default: Console.WriteLine("✗ Invalid"); break;
            }
        }
    }
    
    static void GetVolume()
    {
        float volume = GetVolumeMultiplier();
        Console.WriteLine($"✓ Current volume: {volume}x");
    }
    
    static void SetCustomVolume()
    {
        Console.Write("Enter volume (0.1 - 10.0): ");
        if (float.TryParse(Console.ReadLine(), out float volume))
        {
            if (volume >= 0.1f && volume <= 10.0f)
            {
                SetVolumeMultiplier(volume);
                Console.WriteLine($"✓ Set to {volume}x");
            }
            else
                Console.WriteLine("✗ Must be 0.1 - 10.0");
        }
        else
            Console.WriteLine("✗ Invalid input");
    }
    
    static void SetPreset(float volume, string name)
    {
        SetVolumeMultiplier(volume);
        Console.WriteLine($"✓ {name}");
    }
    
    static void Deactivate()
    {
        CleanupAudioDevice();
        isActive = false;
        Console.WriteLine("✓ Microphone deactivated");
    }
    
    static void Exit()
    {
        if (isActive) CleanupAudioDevice();
        Console.WriteLine("Goodbye!");
        Environment.Exit(0);
    }
}
