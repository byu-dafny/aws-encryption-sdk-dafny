// Copyright Amazon.com Inc. or its affiliates. All Rights Reserved.
// SPDX-License-Identifier: Apache-2.0
// Do not modify this file. This file is machine generated, and any changes to it will be overwritten.
// ReSharper disable RedundantUsingDirective
// ReSharper disable RedundantNameQualifier
// ReSharper disable SuggestVarOrType_SimpleTypes

using System;
using AWS.EncryptionSDK.Core;
using Wrappers_Compile;

namespace AWS.EncryptionSDK.Core
{
    internal class
        NativeWrapper_CryptographicMaterialsManager : Dafny.Aws.EncryptionSdk.Core.ICryptographicMaterialsManager
    {
        internal readonly CryptographicMaterialsManagerBase _impl;

        public NativeWrapper_CryptographicMaterialsManager(CryptographicMaterialsManagerBase nativeImpl)
        {
            _impl = nativeImpl;
        }

        public Wrappers_Compile._IResult<Dafny.Aws.EncryptionSdk.Core._IDecryptMaterialsOutput,
            Dafny.Aws.EncryptionSdk.Core.IAwsCryptographicMaterialProvidersException> DecryptMaterials(
            Dafny.Aws.EncryptionSdk.Core._IDecryptMaterialsInput input)
        {
            void validateOutput(AWS.EncryptionSDK.Core.DecryptMaterialsOutput nativeOutput)
            {
                try
                {
                    nativeOutput.Validate();
                }
                catch (ArgumentException e)
                {
                    var message = $"Output of {_impl}._DecryptMaterials is invalid. {e.Message}";
                    throw new AwsCryptographicMaterialProvidersException(message);
                }
            }

            AWS.EncryptionSDK.Core.DecryptMaterialsInput nativeInput =
                TypeConversion.FromDafny_N3_aws__N13_encryptionSdk__N4_core__S21_DecryptMaterialsInput(input);
            AwsCryptographicMaterialProvidersBaseException finalException = null;
            try
            {
                AWS.EncryptionSDK.Core.DecryptMaterialsOutput nativeOutput = _impl.DecryptMaterials(nativeInput);
                _ = nativeOutput ?? throw new AwsCryptographicMaterialProvidersException(
                    $"{_impl}._DecryptMaterials returned null, should be {typeof(AWS.EncryptionSDK.Core.DecryptMaterialsOutput)}");
                validateOutput(nativeOutput);
                return Wrappers_Compile
                    .Result<Dafny.Aws.EncryptionSdk.Core._IDecryptMaterialsOutput,
                        Dafny.Aws.EncryptionSdk.Core.IAwsCryptographicMaterialProvidersException>
                    .create_Success(
                        TypeConversion.ToDafny_N3_aws__N13_encryptionSdk__N4_core__S22_DecryptMaterialsOutput(
                            nativeOutput));
            }
            catch (AwsCryptographicMaterialProvidersBaseException e)
            {
                finalException = e;
            }
            catch (Exception e)
            {
                var message = $"{_impl}._DecryptMaterials threw unexpected: {e.GetType()}: \"{e.Message}\"";
                finalException = new AwsCryptographicMaterialProvidersBaseException(message);
            }

            return Wrappers_Compile
                .Result<Dafny.Aws.EncryptionSdk.Core._IDecryptMaterialsOutput,
                    Dafny.Aws.EncryptionSdk.Core.IAwsCryptographicMaterialProvidersException>
                .create_Failure(TypeConversion.ToDafny_CommonError(finalException));
        }

        public Wrappers_Compile._IResult<Dafny.Aws.EncryptionSdk.Core._IGetEncryptionMaterialsOutput,
            Dafny.Aws.EncryptionSdk.Core.IAwsCryptographicMaterialProvidersException> GetEncryptionMaterials(
            Dafny.Aws.EncryptionSdk.Core._IGetEncryptionMaterialsInput input)
        {
            void validateOutput(AWS.EncryptionSDK.Core.GetEncryptionMaterialsOutput nativeOutput)
            {
                try
                {
                    nativeOutput.Validate();
                }
                catch (ArgumentException e)
                {
                    var message = $"Output of {_impl}._GetEncryptionMaterials is invalid. {e.Message}";
                    throw new AwsCryptographicMaterialProvidersException(message);
                }
            }

            AWS.EncryptionSDK.Core.GetEncryptionMaterialsInput nativeInput =
                TypeConversion.FromDafny_N3_aws__N13_encryptionSdk__N4_core__S27_GetEncryptionMaterialsInput(input);
            AwsCryptographicMaterialProvidersBaseException finalException = null;
            try
            {
                AWS.EncryptionSDK.Core.GetEncryptionMaterialsOutput nativeOutput =
                    _impl.GetEncryptionMaterials(nativeInput);
                _ = nativeOutput ?? throw new AwsCryptographicMaterialProvidersException(
                    $"{_impl}._GetEncryptionMaterials returned null, should be {typeof(AWS.EncryptionSDK.Core.GetEncryptionMaterialsOutput)}");
                validateOutput(nativeOutput);
                return Wrappers_Compile
                    .Result<Dafny.Aws.EncryptionSdk.Core._IGetEncryptionMaterialsOutput,
                        Dafny.Aws.EncryptionSdk.Core.IAwsCryptographicMaterialProvidersException>
                    .create_Success(TypeConversion
                        .ToDafny_N3_aws__N13_encryptionSdk__N4_core__S28_GetEncryptionMaterialsOutput(nativeOutput));
            }
            catch (AwsCryptographicMaterialProvidersBaseException e)
            {
                finalException = e;
            }
            catch (Exception e)
            {
                var message = $"{_impl}._GetEncryptionMaterials threw unexpected: {e.GetType()}: \"{e.Message}\"";
                finalException = new AwsCryptographicMaterialProvidersBaseException(message);
            }

            return Wrappers_Compile
                .Result<Dafny.Aws.EncryptionSdk.Core._IGetEncryptionMaterialsOutput,
                    Dafny.Aws.EncryptionSdk.Core.IAwsCryptographicMaterialProvidersException>
                .create_Failure(TypeConversion.ToDafny_CommonError(finalException));
        }
    }
}
