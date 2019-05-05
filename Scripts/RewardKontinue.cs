using PS4MK11Macro.Properties;
using PS4MacroAPI;
using static PS4MK11Macro.AllMatchedValues;

namespace PS4MK11Macro
{
    internal class RewardKontinue : Scene
    {
        public override string Name => "RewardKontinue";

        public override bool Match(ScriptBase script)
        {
            return script.MatchTemplate(MenuKontinueButton) || script.MatchTemplate(AltMenuKontinueButton);
        }

        public override void OnMatched(ScriptBase script)
        {
            script.Press(new DualShockState() { Cross = true });
            script.Sleep(Settings.Default.InputDelay);
            script.Press(new DualShockState() { Cross = false });
        }
    }
}