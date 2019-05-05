using MK11Macro.Properties;
using PS4MacroAPI;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace MK11Macro
{
    public class MK11AutoMain : ScriptBase
    {
        public MK11AutoMain()
        {
            Config.Name = "MK11Macro";
            Config.TargetSize = new System.Drawing.Size(1280, 720);
            Config.Scenes = new List<Scene>()
            {
                new KlassicTowerDifficulty(),
                new MatchKontinue(),
                new MatchRetry(),
                new KlassicTowers.SurvivorTower(),
                new CharacterSelectNoob(),
                new CharacterSelectScorpion(),
                new RewardKontinue(),
                new TowerKonsumableScreen(),
                new MatchFailedTowerSelect(),
            };
        }

        public override void Start()
        {
            base.Start();

        }

        public override void Update()
        {
            HandleScenes(x=>
            {
                Console.WriteLine(x.Name);
            });
        }
    }
}