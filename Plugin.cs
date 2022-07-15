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
            frostfireAxe1H.Name.English("Frostfire Axe One Hand"); // You can use this to fix the display name in code
            frostfireAxe1H.Description.English("An axe made to stop a god.");
            frostfireAxe1H.RequiredItems.Add("Ancient Bark", 20);
            frostfireAxe1H.RequiredItems.Add("Silver", 15);
            frostfireAxe1H.RequiredItems.Add("Frostfire Shard", 5);
            frostfireAxe1H.RequiredItems.Add("Deer Hide", 5);
            frostfireAxe1H.RequiredUpgradeItems.Add("Ancient Bark", 5);
            frostfireAxe1H.RequiredUpgradeItems.Add("Silver", 10);
            frostfireAxe1H.RequiredUpgradeItems.Add("Deer Hide", 2);
            frostfireAxe1H.CraftAmount = 1;
            
            Item frostfireAxe2H = new Item("godofworlds", "SMB_FrostfireAxe2H");
            frostfireAxe2H.Crafting.Add(CraftingTable.Forge, 3);
            frostfireAxe2H.Name.English("Frostfire Axe Two Hand"); // You can use this to fix the display name in code
            frostfireAxe2H.Description.English("An masterful weapon i'm sure.");
            frostfireAxe2H.RequiredItems.Add("Ancient Bark", 40);
            frostfireAxe2H.RequiredItems.Add("Silver", 30);
            frostfireAxe2H.RequiredItems.Add("Frostfire Shard", 10);
            frostfireAxe2H.RequiredItems.Add("Deer Hide", 10);
            frostfireAxe2H.RequiredUpgradeItems.Add("Ancient Bark", 5);
            frostfireAxe2H.RequiredUpgradeItems.Add("Silver", 15);
            frostfireAxe2H.RequiredUpgradeItems.Add("Deer Hide", 2);
            frostfireAxe2H.CraftAmount = 1;

            Item frostfireShield = new Item("godofworlds", "SMB_FrostfireShield");
            frostfireShield.Crafting.Add(CraftingTable.Forge, 3);
            frostfireShield.Name.English("Frostfire Shield"); // You can use this to fix the display name in code
            frostfireShield.Description.English("A shield made to stop the gods.");
            frostfireShield.RequiredItems.Add("Ancient Bark", 20);
            frostfireShield.RequiredItems.Add("Silver", 15);
            frostfireShield.RequiredItems.Add("Frostfire Shard", 5);
            frostfireShield.RequiredItems.Add("Deer Hide", 5);
            frostfireShield.RequiredUpgradeItems.Add("Ancient Bark", 5);
            frostfireShield.RequiredUpgradeItems.Add("Silver", 7);
            frostfireShield.RequiredUpgradeItems.Add("Deer Hide", 2);
            frostfireShield.CraftAmount = 1;
            
            Item frostfireBow = new Item("godofworlds", "SMB_FrostfireBow");
            frostfireBow.Crafting.Add(CraftingTable.Forge, 3);
            frostfireBow.Name.English("Frostfire Bow"); // You can use this to fix the display name in code
            frostfireBow.Description.English("The right bow in the right hand has great power.");
            frostfireBow.RequiredItems.Add("Ancient Bark", 20);
            frostfireBow.RequiredItems.Add("Silver", 15);
            frostfireBow.RequiredItems.Add("Frostfire Shard", 5);
            frostfireBow.RequiredItems.Add("Deer Hide", 5);
            frostfireBow.RequiredUpgradeItems.Add("Ancient Bark", 5);
            frostfireBow.RequiredUpgradeItems.Add("Silver", 7);
            frostfireBow.RequiredUpgradeItems.Add("Deer Hide", 2);
            frostfireBow.CraftAmount = 1;
            
            Item frostfireShard = new Item("godofworlds", "SMB_FrostfireShard");
            frostfireShard.Crafting.Add(CraftingTable.Forge, 3);
            frostfireShard.Name.English("Frostfire Shard"); // You can use this to fix the display name in code
            frostfireShard.Description.English("A shard forged with the Fire and Frost of Hati and Skoll.");
            frostfireShard.RequiredItems.Add("Obsidian", 1);
            frostfireShard.RequiredItems.Add("Surtling Core", 2);
            frostfireShard.RequiredItems.Add("Freeze Gland", 2);
            frostfireShard.CraftAmount = 2;
        }
    }
}