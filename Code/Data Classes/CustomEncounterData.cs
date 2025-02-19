﻿using APIPlugin;
using System;
using System.Collections.Generic;
namespace JLPlugin.Data
{
    [System.Serializable]
    public partial class CustomEncounterData
    {

        public string name;

        public List<string> regions;

        public List<string> dominantTribes;
        public int minDifficulty;
        public int maxDifficulty;

        public List<List<CardBlueprintData>> turns;
        public List<string> randomReplacementCards;
        public List<TurnModData> turnMods;

        public List<string> redundantAbilities;
        public List<string> unlockedCardPrerequisites;

        public bool regular;
        public bool bossPrep;
    }
}
