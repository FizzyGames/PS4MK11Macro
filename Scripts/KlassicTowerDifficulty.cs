using PS4MK11Macro.Properties;
using PS4MacroAPI;

namespace PS4MK11Macro
{
    public class KlassicTowerDifficulty : Scene
    {
        public override string Name => "KlassicTowerDifficultyPrompt";

        public override bool Match(ScriptBase script)
        {
            return script.MatchTemplate(AllMatchedValues.KlassicDifficultyPrompt);
        }

        public override void OnMatched(ScriptBase script)
        {
            script.Press(new DualShockState() { DPad_Left = true });
            script.Sleep(Settings.Default.InputDelay);
            script.Press(new DualShockState() { DPad_Left = false });
            script.Sleep(Settings.Default.InputDelay);
            script.Press(new DualShockState() { DPad_Left = true });
            script.Sleep(Settings.Default.InputDelay);
            script.Press(new DualShockState() { DPad_Left = false });
            script.Sleep(Settings.Default.InputDelay);
            script.Press(new DualShockState() { Cross = true });
            script.Sleep(Settings.Default.InputDelay);
            script.Press(new DualShockState() { Cross = false });
        }
    }
}