// Copyright 2021 fpwong. All Rights Reserved.

using UnrealBuildTool;

public class BlueprintAssist : ModuleRules
{
	public BlueprintAssist(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		bUseUnity = false;

		PublicIncludePaths.AddRange(
			new string[]
			{
				// ... add public include paths required here ...
			}
		);

		PrivateIncludePaths.AddRange(
			new string[]
			{
				// ... add other private include paths required here ...
			}
		);


		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				// ... add other public dependencies that you statically link with here ...
			}
		);


		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
				"Engine",
				"Slate",
				"SlateCore",
				// ... add private dependencies that you statically link with here ...
				"GraphEditor",
				"Kismet",
				"KismetWidgets",
				"InputCore",
				"BlueprintGraph",
				"AssetTools",
				"EditorStyle",
				"EditorWidgets",
				"UnrealEd",
				"Projects",
				"Json",
				"JsonUtilities",
				"EngineSettings",
				"AssetRegistry",
			}
		);

		if (Target.Type == TargetType.Editor)
		{
			PrivateDependencyModuleNames.Add("MessageLog");
		}

		if (Target.bWithLiveCoding)
		{
			PrivateIncludePathModuleNames.Add("LiveCoding");
		}

		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				// ... add any modules that your module loads dynamically here ...
			}
		);
	}
}