// Echoes of Eternity game. Copyright Formonder. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class EchoesOfEternityEditorTarget : TargetRules
{
    public EchoesOfEternityEditorTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Editor;
        DefaultBuildSettings = BuildSettingsVersion.V2;

        ExtraModuleNames.AddRange(new string[] { "EchoesOfEternity" });
    }
}
