using MK11Macro.Properties;
using PS4MacroAPI;
using static MK11Macro.AllMatchedValues;

namespace MK11Macro
{
    internal class MatchFailedTowerSelect : Scene
    {
        public override string Name => "MatchTowerSelect";

        public override bool Match(ScriptBase script)
        {
            return script.MatchTemplate(MatchTowerSelectButton);
            //return false;
        }

        public override void OnMatched(ScriptBase script)
        {
            script.Press(new DualShockState() { Cross = true });
            script.Sleep(Settings.Default.InputDelay); 
            script.Press(new DualShockState() { DPad_Right = true });
            script.Sleep(Settings.Default.InputDelay);
            script.Press(new DualShockState() { Cross = true });
        }
    }
}