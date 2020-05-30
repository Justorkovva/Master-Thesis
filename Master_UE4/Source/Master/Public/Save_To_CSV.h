// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "Kismet/BlueprintFunctionLibrary.h"
#include "Save_To_CSV.generated.h"

/**
 *
 */
UCLASS()
class USave_To_CSV : public UBlueprintFunctionLibrary
{
	GENERATED_BODY()

		UFUNCTION(BlueprintCallable, Category = "Custom", meta = (keywords = "Save"))
		static bool SaveArray(FString SaveDirectory, FString Filename, TArray<FString> SaveText);



};
