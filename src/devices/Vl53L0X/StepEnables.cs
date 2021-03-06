﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Iot.Device.Vl53L0X
{
    internal class StepEnables
    {
        public bool Tcc { get; set; }
        public bool Dss { get; set; }
        public bool Msrc { get; set; }
        public bool PreRange { get; set; }
        public bool FinalRange { get; set; }
    }
}
