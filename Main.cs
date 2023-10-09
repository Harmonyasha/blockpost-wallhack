using UnityEngine;
using MelonLoader;
using UnityEngine.UI;
using Boo.Lang;
//using static TestMod.TestMod.wallhack;
using static TestMod.Utility.Log;
using TestMod.Exploit;
using static TestMod.Utility.Updater;
using TestMod.Utility;
using Boo.Lang.Compiler.Pipelines;
using Il2CppSystem.Threading;
using System;
using TestMod.CustomEvent;
using System.Threading;

namespace TestMod
{
    public static class BuildInfo
    {
        public const string Name = "Dunguon master"; // Name of the Mod.  (MUST BE SET)
        public const string Description = "Mod for Sex"; // Description for the Mod.  (Set as null if none)
        public const string Author = "Boss of the gym"; // Author of the Mod.  (MUST BE SET)
        public const string Company = null; // Company that made the Mod.  (Set as null if none)
        public const string Version = "1.0.0"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)
    }

    public class TestMod : MelonMod
    {


        public override void OnInitializeMelon() {
            MelonLogger.Msg("OnApplicationStart");
            //ObjectLogger();
            // new System.Threading.Thread(ObjectLogger).Start();
        }


        private static async void ObjectLogger()
        {
            await ObjectAdded.UpdateAsync();
        }
        public override void OnLateInitializeMelon() // Runs after OnApplicationStart.
        {
            MelonLogger.Msg("OnApplicationLateStart");
            
            //MelonCoroutines.Start(ObjectAdded.update());
        }

    

        public override void OnSceneWasLoaded(int buildindex, string sceneName) // Runs when a Scene has Loaded and is passed the Scene's Build Index and Name.
        {
            MelonLogger.Msg("OnSceneWasLoaded: " + buildindex.ToString() + " | " + sceneName);

            
      
        }

        public override void OnSceneWasInitialized(int buildindex, string sceneName) // Runs when a Scene has Initialized and is passed the Scene's Build Index and Name.
        {
            MelonLogger.Msg("OnSceneWasInitialized: " + buildindex.ToString() + " | " + sceneName);

        }

        public override void OnSceneWasUnloaded(int buildIndex, string sceneName) {
            MelonLogger.Msg("OnSceneWasUnloaded: " + buildIndex.ToString() + " | " + sceneName);
        }

      
  
        



      
        public override void OnUpdate()
        {
            
            Updater.Update();
            if (Input.GetKeyDown(KeyCode.G))
            {
                wallhack.datasaver.run();
            }

        }
     
       
        public override void OnFixedUpdate() // Can run multiple times per frame. Mostly used for Physics.
        {
         //   MelonLogger.Msg("OnFixedUpdate");
        }

        public override void OnLateUpdate() // Runs once per frame after OnUpdate and OnFixedUpdate have finished.
        {
           // MelonLogger.Msg("OnLateUpdate");
        }

        public override void OnGUI() // Can run multiple times per frame. Mostly used for Unity's IMGUI.
        {
       
     
        }

        public override void OnApplicationQuit() // Runs when the Game is told to Close.
        {
            MelonLogger.Msg("OnApplicationQuit");
        }

        public override void OnPreferencesSaved() // Runs when Melon Preferences get saved.
        {
            MelonLogger.Msg("OnPreferencesSaved");
        }

        public override void OnPreferencesLoaded() // Runs when Melon Preferences get loaded.
        {
            MelonLogger.Msg("OnPreferencesLoaded");
        }
    }
}