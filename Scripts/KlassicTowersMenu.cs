﻿using MK11Macro.Properties;
using PS4MacroAPI;
using static MK11Macro.AllMatchedValues;

namespace MK11Macro.KlassicTowers
{
    internal class SurvivorTower : Scene
    {
        public override string Name => "MenuKlassicTowersSurvival";

        public override bool Match(ScriptBase script)
        {
            return script.MatchTemplate(KlassicTowerMenu) && script.MatchTemplate(AllMatchedValues.SurvivorTower);
            //return false;
        }

        public override void OnMatched(ScriptBase script)
        {
            script.Press(new DualShockState() { Cross = true });
            script.Sleep(Settings.Default.TowerStartDelay);
        }
    }
}