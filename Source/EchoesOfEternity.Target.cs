// Echoes of Eternity game. Copyright Formonder. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class EchoesOfEternityTarget : TargetRules
{
    public EchoesOfEternityTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Game;
        DefaultBuildSettings = BuildSettingsVersion.V2;

        ExtraModuleNames.AddRange(new string[] { "EchoesOfEternity" });
    }
}
