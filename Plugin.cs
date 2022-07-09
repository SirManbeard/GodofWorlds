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
            Item leviathanAxe = new Item("leviathanaxe", "leviathanaxe", "Assets");
            leviathanAxe.Crafting.Add(CraftingTable.Forge, 3);
            leviathanAxe.Name.English("Leviathan Axe"); // You can use this to fix the display name in code
            leviathanAxe.Description.English("An axe made the stop the gods.");
            leviathanAxe.RequiredItems.Add("Iron", 20);
            leviathanAxe.RequiredItems.Add("FrozenFlameIngot", 10);
            leviathanAxe.RequiredItems.Add("Silver", 5);
            leviathanAxe.RequiredUpgradeItems.Add("Iron", 12);
            leviathanAxe.RequiredUpgradeItems.Add("FrozenFlameIngot", 2);
            leviathanAxe.RequiredUpgradeItems.Add("Silver", 2);
            leviathanAxe.CraftAmount = 1;

        }
    }
}