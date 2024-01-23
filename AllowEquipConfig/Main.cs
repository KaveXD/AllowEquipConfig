using Harmony;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace AllowEquipConfig
{
    public class Main : VTOLMOD
    {
        public override void ModLoaded()
        {
            Debug.Log("Started Loading");
            HarmonyInstance harmonyInstance = HarmonyInstance.Create("KaveKave:AllowEquipConfig");
            Debug.Log("Created Instance");
            harmonyInstance.PatchAll(Assembly.GetExecutingAssembly());
            Debug.Log("AllowEquipConfig Loaded!");
            base.ModLoaded();
        }
    }
}