﻿using System;
using StardewValley;

namespace FarmExpansion.Framework
{
    /// <summary>An API provided by Farm Expansion for other mods to use.</summary>
    public interface IModApi
    {
        /// <summary>Add a blueprint to all future carpenter menus for the farm area.</summary>
        /// <param name="blueprint">The blueprint to add.</param>
        void AddFarmBluePrint(BluePrint blueprint);

        /// <summary>Add a blueprint to all future carpenter menus for the expansion area.</summary>
        /// <param name="blueprint">The blueprint to add.</param>
        void AddExpansionBluePrint(BluePrint blueprint);

        /// <summary>
        /// Mod removes itself from game world in BeforeSave and handles saving separately.
        /// Hook this if you need to do some fixup to contained stuff (FurnitureAnywhere, Tractor etc).
        /// </summary>
        /// <param name="handler"></param>
        void AddRemoveListener(EventHandler handler);

        /// <summary>
        /// Second half for AddRemoveListener
        /// </summary>
        void AddAppendListener(EventHandler handler);
    }
}