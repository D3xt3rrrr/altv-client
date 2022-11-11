using AltV.Net;
using gamemode.core.Entity.Vehicle;
using gamemode.Player;

namespace gamemode.core.Event;

public class LsCustomEvent : IScript
{
    [ClientEvent("lscustom:updateWindows")]
    public static void updateWindowsEvent(MyPlayer player, MyVehicle veh)
    {
        
    }
}