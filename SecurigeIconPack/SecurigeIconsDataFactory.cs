﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurigeIconPack
{
    public static class SecurigeIconsDataFactory
    {
        public static Lazy<IDictionary<SecurigeIconsKind, string>> DataIndex { get; }

        static SecurigeIconsDataFactory()
        {
            if (DataIndex == null)
            {
                DataIndex = new Lazy<IDictionary<SecurigeIconsKind, string>>(SecurigeIconsDataFactory.Create);
            }
        }

        public static IDictionary<SecurigeIconsKind, string> Create()
        {
            return new Dictionary<SecurigeIconsKind, string>
            {
                {SecurigeIconsKind.HomeSolid, "M280.37 148.26L96 300.11V464a16 16 0 0 0 16 16l112.06-.29a16 16 0 0 0 15.92-16V368a16 16 0 0 1 16-16h64a16 16 0 0 1 16 16v95.64a16 16 0 0 0 16 16.05L464 480a16 16 0 0 0 16-16V300L295.67 148.26a12.19 12.19 0 0 0-15.3 0zM571.6 251.47L488 182.56V44.05a12 12 0 0 0-12-12h-56a12 12 0 0 0-12 12v72.61L318.47 43a48 48 0 0 0-61 0L4.34 251.47a12 12 0 0 0-1.6 16.9l25.5 31A12 12 0 0 0 45.15 301l235.22-193.74a12.19 12.19 0 0 1 15.3 0L530.9 301a12 12 0 0 0 16.9-1.6l25.5-31a12 12 0 0 0-1.7-16.93z"},
                {SecurigeIconsKind.FireSolid, "M216 23.86c0-23.8-30.65-32.77-44.15-13.04C48 191.85 224 200 224 288c0 35.63-29.11 64.46-64.85 63.99-35.17-.45-63.15-29.77-63.15-64.94v-85.51c0-21.7-26.47-32.23-41.43-16.5C27.8 213.16 0 261.33 0 320c0 105.87 86.13 192 192 192s192-86.13 192-192c0-170.29-168-193-168-296.14z"},
                {SecurigeIconsKind.MedkitSolid, "M96 480h320V128h-32V80c0-26.51-21.49-48-48-48H176c-26.51 0-48 21.49-48 48v48H96v352zm96-384h128v32H192V96zm320 80v256c0 26.51-21.49 48-48 48h-16V128h16c26.51 0 48 21.49 48 48zM64 480H48c-26.51 0-48-21.49-48-48V176c0-26.51 21.49-48 48-48h16v352zm288-208v32c0 8.837-7.163 16-16 16h-48v48c0 8.837-7.163 16-16 16h-32c-8.837 0-16-7.163-16-16v-48h-48c-8.837 0-16-7.163-16-16v-32c0-8.837 7.163-16 16-16h48v-48c0-8.837 7.163-16 16-16h32c8.837 0 16 7.163 16 16v48h48c8.837 0 16 7.163 16 16z"},
                {SecurigeIconsKind.ToolsSolid, "M501.1 395.7L384 278.6c-23.1-23.1-57.6-27.6-85.4-13.9L192 158.1V96L64 0 0 64l96 128h62.1l106.6 106.6c-13.6 27.8-9.2 62.3 13.9 85.4l117.1 117.1c14.6 14.6 38.2 14.6 52.7 0l52.7-52.7c14.5-14.6 14.5-38.2 0-52.7zM331.7 225c28.3 0 54.9 11 74.9 31l19.4 19.4c15.8-6.9 30.8-16.5 43.8-29.5 37.1-37.1 49.7-89.3 37.9-136.7-2.2-9-13.5-12.1-20.1-5.5l-74.4 74.4-67.9-11.3L334 98.9l74.4-74.4c6.6-6.6 3.4-17.9-5.7-20.2-47.4-11.7-99.6.9-136.6 37.9-28.5 28.5-41.9 66.1-41.2 103.6l82.1 82.1c8.1-1.9 16.5-2.9 24.7-2.9zm-103.9 82l-56.7-56.7L18.7 402.8c-25 25-25 65.5 0 90.5s65.5 25 90.5 0l123.6-123.6c-7.6-19.9-9.9-41.6-5-62.7zM64 472c-13.2 0-24-10.8-24-24 0-13.3 10.7-24 24-24s24 10.7 24 24c0 13.2-10.7 24-24 24z"},
                {SecurigeIconsKind.UnlockSolid, "M400 256H152V152.9c0-39.6 31.7-72.5 71.3-72.9 40-.4 72.7 32.1 72.7 72v16c0 13.3 10.7 24 24 24h32c13.3 0 24-10.7 24-24v-16C376 68 307.5-.3 223.5 0 139.5.3 72 69.5 72 153.5V256H48c-26.5 0-48 21.5-48 48v160c0 26.5 21.5 48 48 48h352c26.5 0 48-21.5 48-48V304c0-26.5-21.5-48-48-48z"},
                {SecurigeIconsKind.LockSolid, "M400 224h-24v-72C376 68.2 307.8 0 224 0S72 68.2 72 152v72H48c-26.5 0-48 21.5-48 48v192c0 26.5 21.5 48 48 48h352c26.5 0 48-21.5 48-48V272c0-26.5-21.5-48-48-48zm-104 0H152v-72c0-39.7 32.3-72 72-72s72 32.3 72 72v72z"},
                {SecurigeIconsKind.BatteryOffOutline, "M18 17.35L3.38 2.73L2.11 4L6 7.89V20.67A1.34 1.34 0 0 0 7.33 22H16.67A1.34 1.34 0 0 0 18 20.67V19.89L20.84 22.73L22.11 21.46M16 20H8V9.89L16 17.89M16 6V12.8L18 14.8V5.33A1.34 1.34 0 0 0 16.67 4H15V2H9V4H7.21L9.21 6Z"},
                {SecurigeIconsKind.BatteryOutline, "M16,20H8V6H16M16.67,4H15V2H9V4H7.33A1.33,1.33 0 0,0 6,5.33V20.67C6,21.4 6.6,22 7.33,22H16.67A1.33,1.33 0 0,0 18,20.67V5.33C18,4.6 17.4,4 16.67,4Z"},
                {SecurigeIconsKind.BatteryChargingOutline, "M23.05,11H20.05V4L15.05,14H18.05V22M12,20H4L4.05,6H12.05M12.72,4H11.05V2H5.05V4H3.38A1.33,1.33 0 0,0 2.05,5.33V20.67C2.05,21.4 2.65,22 3.38,22H12.72C13.45,22 14.05,21.4 14.05,20.67V5.33A1.33,1.33 0 0,0 12.72,4Z"},
                {SecurigeIconsKind.BatteryLow, "M16 20H8V6H16M16.67 4H15V2H9V4H7.33C6.6 4 6 4.6 6 5.33V20.67C6 21.4 6.6 22 7.33 22H16.67C17.41 22 18 21.41 18 20.67V5.33C18 4.6 17.4 4 16.67 4M15 16H9V19H15V16"},
                {SecurigeIconsKind.BatteryChargingLow, "M12 20H4V6H12M12.67 4H11V2H5V4H3.33C2.6 4 2 4.6 2 5.33V20.67C2 21.4 2.6 22 3.33 22H12.67C13.41 22 14 21.41 14 20.67V5.33C14 4.6 13.4 4 12.67 4M11 16H5V19H11V16M23 10H20V3L15 13H18V21"},
                {SecurigeIconsKind.BatteryHigh, "M16 20H8V6H16M16.67 4H15V2H9V4H7.33C6.6 4 6 4.6 6 5.33V20.67C6 21.4 6.6 22 7.33 22H16.67C17.41 22 18 21.41 18 20.67V5.33C18 4.6 17.4 4 16.67 4M15 16H9V19H15V16M15 7H9V10H15V7M15 11.5H9V14.5H15V11.5Z"},
                {SecurigeIconsKind.BatteryChargingHigh, "M12 20H4V6H12M12.67 4H11V2H5V4H3.33C2.6 4 2 4.6 2 5.33V20.67C2 21.4 2.6 22 3.33 22H12.67C13.41 22 14 21.41 14 20.67V5.33C14 4.6 13.4 4 12.67 4M11 16H5V19H11V16M11 7H5V10H11V7M11 11.5H5V14.5H11V11.5M23 10H20V3L15 13H18V21"},
            };
        }
    }
}