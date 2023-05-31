// Aleksandr Lipovskiy | Indie game developer

using UnrealBuildTool;
using System.Collections.Generic;

public class RBEditorTarget : TargetRules
{
	public RBEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "RB" } );
	}
}
