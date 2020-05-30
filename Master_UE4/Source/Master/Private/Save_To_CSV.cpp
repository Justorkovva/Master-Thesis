// Fill out your copyright notice in the Description page of Project Settings.


#include "Save_To_CSV.h"
#include "Misc/FileHelper.h"
#include "HAL/PlatformFilemanager.h"

bool USave_To_CSV::SaveArray(FString SaveDirectory, FString Filename, TArray<FString> SaveText)
{
	SaveDirectory += "\\";
	SaveDirectory += Filename;

	FString FinalString = "";
	for (FString& Each : SaveText)
	{
		FinalString += Each;
		FinalString += LINE_TERMINATOR;
	}

	return FFileHelper::SaveStringToFile(FinalString, *SaveDirectory);
}


