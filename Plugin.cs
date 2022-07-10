using System.IO;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using HarmonyLib;
using ItemManager;
using ServerSync;
using UnityEngine;


namespace GodofWorlds
{
    [BepInPlugin(ModGUID, ModName, ModVersion)]
    public class GodofWorlds : BaseUnityPlugin
    {
        private const string ModName = "GodofWorlds";
        private const string ModVersion = "0.0.1";
        private const string ModGUID = "org.bepinex.plugins.godofworlds";

        public void Awake()
        {
            Item leviathanAxe1H = new Item("leviathanweapons", "SMB_LeviathanAxe1H");
            leviathanAxe1H.Crafting.Add(CraftingTable.Forge, 3);
            leviathanAxe1H.Name.English("Leviathan Axe - One Hand"); // You can use this to fix the display name in code
            leviathanAxe1H.Description.English("An axe made the stop the gods.");
            leviathanAxe1H.RequiredItems.Add("Iron", 15);
            leviathanAxe1H.RequiredItems.Add("FrozenFlameIngot", 8);
            leviathanAxe1H.RequiredItems.Add("Silver", 3);
            leviathanAxe1H.RequiredUpgradeItems.Add("Iron", 7);
            leviathanAxe1H.RequiredUpgradeItems.Add("FrozenFlameIngot", 1);
            leviathanAxe1H.RequiredUpgradeItems.Add("Silver", 1);
            leviathanAxe1H.CraftAmount = 1;
            
            Item leviathanAxe2H = new Item("leviathanweapons", "SMB_LeviathanAxe2H");
            leviathanAxe2H.Crafting.Add(CraftingTable.Forge, 3);
            leviathanAxe2H.Name.English("Leviathan Axe - Two Hand"); // You can use this to fix the display name in code
            leviathanAxe2H.Description.English("An axe made the stop the gods.");
            leviathanAxe2H.RequiredItems.Add("Iron", 20);
            leviathanAxe2H.RequiredItems.Add("FrozenFlameIngot", 10);
            leviathanAxe2H.RequiredItems.Add("Silver", 5);
            leviathanAxe2H.RequiredUpgradeItems.Add("Iron", 12);
            leviathanAxe2H.RequiredUpgradeItems.Add("FrozenFlameIngot", 2);
            leviathanAxe2H.RequiredUpgradeItems.Add("Silver", 2);
            leviathanAxe2H.CraftAmount = 1;
            
        }
    }
}