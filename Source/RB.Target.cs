// Aleksandr Lipovskiy | Indie game developer

using UnrealBuildTool;
using System.Collections.Generic;

public class RBTarget : TargetRules
{
	public RBTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "RB" } );
	}
}
