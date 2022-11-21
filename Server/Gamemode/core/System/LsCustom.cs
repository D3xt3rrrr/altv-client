using System.Runtime.Versioning;
using AltV.Net.Enums;
using gamemode.core.Entity.Vehicle;
using gamemode.Player;

namespace gamemode.core.System;

public class LsCustom
{
    public static bool UpdateWindowTint(MyVehicle veh, byte value)
    {
        if (value > 0 || value > 6)
            return false;
        veh.ModKit = 1;
        veh.WindowTint = value;
        return true;
    }
    
    public static bool UpdateMod(MyVehicle veh, byte categorie, byte level)
    {
        veh.ModKit = 1;
        veh.SetMod(categorie, level);
        return true;
    }
}