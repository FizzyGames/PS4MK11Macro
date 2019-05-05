using MK11Macro.Properties;
using PS4MacroAPI;
using PS4MacroAPI.Internal;
using System.Drawing;

namespace MK11Macro
{
    public static class AllMatchedValues
    {
        private static readonly MatchedValue _characterSelectNoob = new MatchedValue(17520165875049284, new Rectangle(144, 226, 62, 82), "selectNoob");
        private static readonly MatchedValue _characterSelectNoobVariant = new MatchedValue(5710961798797016894, new Rectangle(145, 536, 248, 93), "noobVariant", 90);
        private static readonly MatchedValue _characterSelectScorpion = new MatchedValue(17591634131746816, new Rectangle(80, 226, 61, 82), "selectScorpion");
        private static readonly MatchedValue _klassicDifficultyPrompt = new MatchedValue(9187130475882023167, new Rectangle(412, 457, 441, 121), "difficulty");
        private static readonly MatchedValue _klassicTowerMenu = new MatchedValue(64946638847, new Rectangle(59, 9, 162, 46), "klassictower");
        private static readonly MatchedValue _matchKontinueButton = new MatchedValue(17519885609221662, new Rectangle(514, 607, 234, 23), "matchKontinue");
        private static readonly MatchedValue _menuKontinueButton = new MatchedValue(32433437085952, new Rectangle(575, 642, 120, 30), "menuKontinue");
        private static readonly MatchedValue _retryButton = new MatchedValue(17517686585966108, new Rectangle(515, 565, 254, 24), "retry");
        private static readonly MatchedValue _survivorTower = new MatchedValue(2053368789843509248, new Rectangle(891, 69, 338, 160), "survivor");
        private static readonly MatchedValue _towerKonsumablePrompt = new MatchedValue(547595616272, new Rectangle(96, 621, 275, 48), "konsumable");
        private static readonly MatchedValue _altMenuKontinue = new MatchedValue(1195716739284736, new Rectangle(569, 647, 128, 23), "altkontinue");
        private static readonly MatchedValue _matchTowerSelectButton = new MatchedValue(16954736632544828, new Rectangle(485, 589, 315, 23), "matchTowerSelect");
        public static MatchedValue CharacterSelectNoob => _characterSelectNoob;
        public static MatchedValue CharacterSelectNoobVariant => _characterSelectNoobVariant;
        public static MatchedValue CharacterSelectScorpion => _characterSelectScorpion;
        public static MatchedValue KlassicDifficultyPrompt => _klassicDifficultyPrompt;
        public static MatchedValue KlassicTowerMenu => _klassicTowerMenu;
        public static MatchedValue MatchKontinueButton => _matchKontinueButton;
        public static MatchedValue MatchRetryButton => _retryButton;
        public static MatchedValue MenuKontinueButton => _menuKontinueButton;
        public static MatchedValue SurvivorTower => _survivorTower;
        public static MatchedValue TowerKonsumablePrompt => _towerKonsumablePrompt;
        public static MatchedValue AltMenuKontinueButton => _altMenuKontinue;
        public static MatchedValue MatchTowerSelectButton => _matchTowerSelectButton;
        public static bool MatchTemplate(this ScriptBase script, MatchedValue matchedValue)
        {
            bool matched = script.MatchTemplate(matchedValue.Position, matchedValue.Hash, matchedValue.Similarity);
#if DEBUG
            if (Settings.Default.CreateDebugScreenshots)
            {
                var cropped = script.CropFrame(script.CurrentFrame, matchedValue.Position);
                var hash = ImageHashing.AverageHash(cropped);
                var similarity = ImageHashing.Similarity(hash, matchedValue.Hash);
                if (!matched)
                    cropped.Save($"lastnotmatch_{matchedValue.ID}.png");
            }
#endif
            return matched;
        }
    }

    public class MatchedValue
    {
        public const float SIMILARITY_DEFAULT = 95;

        public MatchedValue(ulong hash, Rectangle position, string id, float similarity = SIMILARITY_DEFAULT)
        {
            Hash = hash;
            Position = position;
            Similarity = similarity;
            ID = id;
        }

        public ulong Hash { get; set; }
        public Rectangle Position { get; set; }
        public float Similarity { get; set; }
        public string ID { get; set; }
    }
}