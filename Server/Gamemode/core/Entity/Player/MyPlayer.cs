using System.ComponentModel;
using AltV.Net;
using AltV.Net.Data;
using AltV.Net.Enums;

namespace gamemode.Player;

[DataObject]
public class MyPlayer : AltV.Net.Elements.Entities.Player
{
    public string Id { get; set; }
    public float X { get; set; }
    public float Y { get; set; }
    public float Z { get; set; }
    public bool LoggedIn { get; set; }
    public MyPlayer(ICore core, IntPtr nativePointer, ushort id) : base(core, nativePointer, id)
    {
        this.LoggedIn = false;
    }
}