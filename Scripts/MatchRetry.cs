using PS4MK11Macro.Properties;
using PS4MacroAPI;
using static PS4MK11Macro.AllMatchedValues;

namespace PS4MK11Macro
{
    internal class MatchRetry : Scene
    {
        public override string Name => "MatchRetry";

        public override bool Match(ScriptBase script)
        {
            return script.MatchTemplate(MatchRetryButton);
            //return false;
        }

        public override void OnMatched(ScriptBase script)
        {
            script.Press(new DualShockState() { Cross = true });
        }
    }
}