using MK11Macro.Properties;
using PS4MacroAPI;

namespace MK11Macro
{
    public class CharacterSelectScorpion : Scene
    {
        public override string Name => "CharacterSelectSceneScorpion";

        public override bool Match(ScriptBase script)
        {
            return script.MatchTemplate(AllMatchedValues.CharacterSelectScorpion);
        }

        public override void OnMatched(ScriptBase script)
        {
            script.Press(new DualShockState() { DPad_Right = true });
            script.Sleep(Settings.Default.InputDelay);
            script.Press(new DualShockState() { DPad_Right = false });
        }
    }
}