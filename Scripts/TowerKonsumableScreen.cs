using PS4MK11Macro.Properties;
using PS4MacroAPI;
using static PS4MK11Macro.AllMatchedValues;

namespace PS4MK11Macro
{
    internal class TowerKonsumableScreen : Scene
    {
        public override string Name => "TowerKonsumableSkip";

        public override bool Match(ScriptBase script)
        {
            return script.MatchTemplate(TowerKonsumablePrompt);
        }

        public override void OnMatched(ScriptBase script)
        {
            script.Press(new DualShockState() { Cross = true });
        }
    }
}