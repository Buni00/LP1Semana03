using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerPerks
{
    [Flags]
    enum Perks
    {  
        None = 1 << 0,     
        WaterBreathing = 1 << 1,
        Stealth = 1 << 2,
        AutoHeal = 1 << 3,
        DoubleJump = 1 << 4
    };
}
