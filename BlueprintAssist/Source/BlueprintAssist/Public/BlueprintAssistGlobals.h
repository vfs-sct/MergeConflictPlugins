// Copyright 2021 fpwong. All Rights Reserved.

#pragma once

BLUEPRINTASSIST_API DECLARE_LOG_CATEGORY_EXTERN(LogBlueprintAssist, Log, All);

#define BA_UE_MINOR_VERSION_OR_LATER(major, minor) ENGINE_MAJOR_VERSION == major && ENGINE_MINOR_VERSION >= minor
#define BA_UE_VERSION_OR_LATER(major, minor) ENGINE_MAJOR_VERSION == major && ENGINE_MINOR_VERSION >= minor || ENGINE_MAJOR_VERSION > major

class BLUEPRINTASSIST_API FBAGlobals
{
public:
	static FBAGlobals& Get();
};
