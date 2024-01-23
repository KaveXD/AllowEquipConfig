using Harmony;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace AllowEquipConfig
{
    [HarmonyPatch(typeof(MissionBriefingUI), nameof(MissionBriefingUI.InitializeMission))]
    public class equipPatch
    {
        public class ForcedEquip
        {
            public int hardpointIdx;

            public string weaponName;
        }
        public static void Prefix(CampaignScenario cs)
        {
            Debug.Log("prefix");
            cs.equipConfigurable = true;
            cs.forcedEquips = null;
        }
    }

}
