using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurigeIconPack
{
    public enum SecurigeIconsKind
    {
        [Description("Empty placeholder")] None,
        [Description("home")] HomeSolid,
        [Description("fire")] FireSolid,
        [Description("medkit")] MedkitSolid,
        [Description("Tools")] ToolsSolid,
        [Description("unlock")] UnlockSolid,
        [Description("lock")] LockSolid,
        [Description("battery-off-outline")] BatteryOffOutline,
        [Description("battery-outline")] BatteryOutline,
        [Description("battery-charging-outline")] BatteryChargingOutline,
        [Description("battery-low")] BatteryLow,
        [Description("battery-charging-low")] BatteryChargingLow,
        [Description("battery-high")] BatteryHigh,
        [Description("battery-charging-high")] BatteryChargingHigh,
    }
}
