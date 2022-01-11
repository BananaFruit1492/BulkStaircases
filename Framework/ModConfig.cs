﻿using StardewModdingAPI.Utilities;

namespace BulkStaircases.Framework
{
    internal class ModConfig
    {
        private int _numberOfStaircasesToLeaveInStack = 0;
        /// <summary>Number of staircases left in the held stack of staircases.</summary>
        public int NumberOfStaircasesToLeaveInStack
        {
            get
            {
                return this._numberOfStaircasesToLeaveInStack;
            }
            set
            {
                if (value < 0)
                    this._numberOfStaircasesToLeaveInStack = 0;
                else
                    this._numberOfStaircasesToLeaveInStack = value;
            }
        }

        /// <summary>Whether to skip level 100 in skull cavern.</summary>
        public bool SkipLevel100SkullCavern { get; set; } = false;

        /// <summary>Whether to skip level 100 in skull cavern.</summary>
        public bool SkipDinosaurLevels { get; set; } = false;

        /// <summary>Whether to skip levels with treasure.</summary>
        public bool SkipTreasureLevels { get; set; } = false;

        /// <summary>Whether to skip quarry dungeon levels that may appear after having been to the quarry mine.</summary>
        public bool SkipQuarryDungeonLevels { get; set; } = true;

        /// <summary>Whether to skip slime infested levels.</summary>
        public bool SkipSlimeLevels { get; set; } = false;

        /// <summary>Whether to skip monster infested levels.</summary>
        public bool SkipMonsterLevels { get; set; } = false;
        
        public KeybindList ToggleKey { get; set; } = KeybindList.Parse("LeftShift + C");
    }
}
