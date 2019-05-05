using MK11Macro.Properties;
using PS4MacroAPI;
using static MK11Macro.AllMatchedValues;

namespace MK11Macro
{
    internal class MatchKontinue : Scene
    {
        public override string Name => "MatchKontinue";

        public override bool Match(ScriptBase script)
        {
            return script.MatchTemplate(MatchKontinueButton);
            //return false;
        }

        public override void OnMatched(ScriptBase script)
        {
            script.Press(new DualShockState() { Cross = true });
        }
    }
}