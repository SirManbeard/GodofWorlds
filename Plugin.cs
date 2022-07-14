using System.IO;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using HarmonyLib;
using ItemManager;
using ServerSync;
using UnityEngine;


namespace GodOfWorlds
{
    [BepInPlugin(ModGuid, ModName, ModVersion)]
    public class GodofWorlds : BaseUnityPlugin
    {
        private const string ModName = "GodofWorlds";
        private const string ModVersion = "0.0.1";
        private const string ModGuid = "org.bepinex.plugins.godofworlds";

        public void Awake()
        {
            Item frostfireAxe1H = new Item("godofworlds", "SMB_FrostfireAxe1H");
            frostfireAxe1H.Crafting.Add(CraftingTable.Forge, 3);
            frostfireAxe1H.Name.English("Frostfire Axe One Han"); // You can use this to fix the display name in code
            frostfireAxe1H.Description.English("An Axe fit for a god, to end a god.");
            frostfireAxe1H.RequiredItems.Add("Iron", 15);
            frostfireAxe1H.RequiredItems.Add("Copper", 8);
            frostfireAxe1H.RequiredItems.Add("Silver", 3);
            frostfireAxe1H.RequiredUpgradeItems.Add("Iron", 7);
            frostfireAxe1H.RequiredUpgradeItems.Add("Copper", 1);
            frostfireAxe1H.RequiredUpgradeItems.Add("Silver", 1);
            frostfireAxe1H.CraftAmount = 1;
            
            Item frostfireAxe2H = new Item("godofworlds", "SMB_FrostfireAxe2H");
            frostfireAxe2H.Crafting.Add(CraftingTable.Forge, 3);
            frostfireAxe2H.Name.English("Frostfire Axe Two Hand"); // You can use this to fix the display name in code
            frostfireAxe2H.Description.English("An axe made the stop the gods. But much bigger.");
            frostfireAxe2H.RequiredItems.Add("Iron", 15);
            frostfireAxe2H.RequiredItems.Add("Copper", 8);
            frostfireAxe2H.RequiredItems.Add("Silver", 3);
            frostfireAxe2H.RequiredUpgradeItems.Add("Iron", 7);
            frostfireAxe2H.RequiredUpgradeItems.Add("Copper", 1);
            frostfireAxe2H.RequiredUpgradeItems.Add("Silver", 1);
            frostfireAxe2H.CraftAmount = 1;
            
            Item leviathanAxe1Htest = new Item("godofworlds", "SMB_LeviathanAxe1H_TEST");
            leviathanAxe1Htest.Crafting.Add(CraftingTable.Forge, 3);
            leviathanAxe1Htest.Name.English("Leviathan Axe One Hand TEST"); // You can use this to fix the display name in code
            leviathanAxe1Htest.Description.English("An Axe fit for a god, to end a god.TEST");
            leviathanAxe1Htest.RequiredItems.Add("Iron", 15);
            leviathanAxe1Htest.RequiredItems.Add("Copper", 8);
            leviathanAxe1Htest.RequiredItems.Add("Silver", 3);
            leviathanAxe1Htest.RequiredUpgradeItems.Add("Iron", 7);
            leviathanAxe1Htest.RequiredUpgradeItems.Add("Copper", 1);
            leviathanAxe1Htest.RequiredUpgradeItems.Add("Silver", 1);
            leviathanAxe1Htest.CraftAmount = 1;
            
            Item frostfireShield = new Item("godofworlds", "SMB_FrostfireShield");
            frostfireShield.Crafting.Add(CraftingTable.Forge, 3);
            frostfireShield.Name.English("Frostfire Shield"); // You can use this to fix the display name in code
            frostfireShield.Description.English("A shield made to stop the gods.");
            frostfireShield.RequiredItems.Add("Iron", 15);
            frostfireShield.RequiredItems.Add("Copper", 8);
            frostfireShield.RequiredItems.Add("Silver", 3);
            frostfireShield.RequiredUpgradeItems.Add("Iron", 7);
            frostfireShield.RequiredUpgradeItems.Add("Copper", 1);
            frostfireShield.RequiredUpgradeItems.Add("Silver", 1);
            frostfireShield.CraftAmount = 1;
            
            Item frostfireBow = new Item("godofworlds", "SMB_Frostfire_Bow");
            frostfireBow.Crafting.Add(CraftingTable.Forge, 3);
            frostfireBow.Name.English("Frostfire Bow"); // You can use this to fix the display name in code
            frostfireBow.Description.English("The right bow in the right hand has great power.");
            frostfireBow.RequiredItems.Add("Iron", 15);
            frostfireBow.RequiredItems.Add("Copper", 8);
            frostfireBow.RequiredItems.Add("Silver", 3);
            frostfireBow.RequiredUpgradeItems.Add("Iron", 7);
            frostfireBow.RequiredUpgradeItems.Add("Copper", 1);
            frostfireBow.RequiredUpgradeItems.Add("Silver", 1);
            frostfireBow.CraftAmount = 1;
        }
    }
}