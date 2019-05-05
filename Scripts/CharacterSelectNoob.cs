
using PS4MacroAPI;
using System.Drawing;
using System;
using PS4MK11Macro.Properties;

namespace PS4MK11Macro
{
    public class CharacterSelectNoob : Scene
    {
        public override string Name => "CharacterSelectSceneNoob";

        public override bool Match(ScriptBase script)
        {
            return script.MatchTemplate(AllMatchedValues.CharacterSelectNoob);
        }

        public override void OnMatched(ScriptBase script)
        {
            script.Press(new DualShockState() { Cross = true });
            script.Sleep(Settings.Default.InputDelay);
            script.Press(new DualShockState() { Square = true });
            script.Sleep(Settings.Default.InputDelay);
            script.Press(new DualShockState() { Cross = true });
            script.Sleep(Settings.Default.InputDelay);
        }
    }
}