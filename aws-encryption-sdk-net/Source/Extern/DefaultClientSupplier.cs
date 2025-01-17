// Copyright Amazon.com Inc. or its affiliates. All Rights Reserved.
// SPDX-License-Identifier: Apache-2.0

using Amazon;
using Amazon.KeyManagementService;
using Amazon.Runtime;
// ReSharper disable once RedundantUsingDirective
using AWS.EncryptionSDK.Core;

// ReSharper disable once RedundantUsingDirective
using Wrappers_Compile;

namespace DefaultClientSupplier
{
    // ReSharper disable once RedundantExtendsListEntry
    public partial class DefaultClientSupplier : Dafny.Aws.EncryptionSdk.Core.IClientSupplier
    {
        // ReSharper disable once RedundantNameQualifier
        public Wrappers_Compile._IResult<Dafny.Com.Amazonaws.Kms.IKeyManagementServiceClient,
            Dafny.Aws.EncryptionSdk.Core.IAwsCryptographicMaterialProvidersException> GetClient(
            Dafny.Aws.EncryptionSdk.Core._IGetClientInput input)
        {
            GetClientInput convertedInput =
                AWS.EncryptionSDK.Core.TypeConversion.FromDafny_N3_aws__N13_encryptionSdk__N4_core__S14_GetClientInput(input);
            try
            {
                IAmazonKeyManagementService client;
                if (convertedInput.Region != "")
                {
                    var regionEndpoint = RegionEndpoint.GetBySystemName(convertedInput.Region);
                    client = new AmazonKeyManagementServiceClient(regionEndpoint);
                }
                else
                {
                    client = new AmazonKeyManagementServiceClient();
                }

                // ReSharper disable once RedundantNameQualifier
                return Wrappers_Compile.Result<Dafny.Com.Amazonaws.Kms.IKeyManagementServiceClient,
                    Dafny.Aws.EncryptionSdk.Core.IAwsCryptographicMaterialProvidersException>.create_Success(
                    AWS.EncryptionSDK.Core.TypeConversion.ToDafny_N3_aws__N13_encryptionSdk__N4_core__S15_GetClientOutput__M6_client(client)
                );
            }
            catch (AmazonServiceException e)
            {
                return Result<Dafny.Com.Amazonaws.Kms.IKeyManagementServiceClient,
                    Dafny.Aws.EncryptionSdk.Core.IAwsCryptographicMaterialProvidersException>.create_Failure(
                    AWS.EncryptionSDK.Core.TypeConversion.ToDafny_CommonError(e)
                );
            }
        }
    }
}
