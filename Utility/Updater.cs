using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TestMod.Exploit;
using TestMod.CustomEvent;
using MelonLoader;
using static TestMod.Utility.Log;
using System.Collections;
using Il2CppSystem.Threading;

namespace TestMod.Utility
{
    internal class Updater
    {
        public static void Update()
        {
            wallhack.datasaver.update();
            //ObjectAdded.update();
        }
    
    }
}
