// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class UnrealBlankProjectEditorTarget : TargetRules
{
	public UnrealBlankProjectEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
        DefaultBuildSettings = BuildSettingsVersion.Latest;
		ExtraModuleNames.AddRange( new string[] { "UnrealBlankProject" } );
		bLegacyParentIncludePaths = false;
        CppStandard = CppStandardVersion.Default;
        WindowsPlatform.bStrictConformanceMode = true;
        IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
	}
}
