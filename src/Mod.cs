using System.Drawing;
using GMSL;
using Underanalyzer;
using UndertaleModLib;
using UndertaleModLib.Util;
using UndertaleModLib.Models;

namespace forceresolution;

public class Mod : GMSLMod
{
    // Runs when patching the game when changes are detected.
    public override void Patch()
    {
        Console.WriteLine($"[forceResolution]: Adding code...");
        AddCode();
    }

    // Runs before every startup.
    public override void Start() {}

    public void AddCode()
    {
        HookFunctionFromFile("hook_window_size.gml", "update_window_size");
    }
}
