include "../src//AwsCryptographicMaterialProviders/Keyrings/AwsKms/AwsKmsKeyring.dfy"
module AwsKmsKeyringUnitTests {
import StandardLibrary
import StandardLibrary.UInt
import Wrappers
import UTF8
import HMAC
import Signature
import AESEncryption
import Seq
import Math
import Actions
import Constants
import AwsKmsArnParsing
import AwsKmsMrkMatchForDecrypt
import MaterialProviders
import MaterialProviders.AwsKmsKeyring
import MaterialProviders.Keyring
import MaterialProviders.Materials
import MaterialProviders.AlgorithmSuites
import Aws
import Aws.Crypto
import Com
import Com.Amazonaws
import Com.Amazonaws.Kms
method {:test} test0() {
var v0 := getFreshMaterialProvidersAwsKmsKeyringOnDecryptEncryptedDataKeyFilter();
var d0 : UTF8.ValidUTF8Bytes := [220, 187, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
var d1 : seq<StandardLibrary.UInt.uint8> := [213, 171, 0];
var d2 : seq<StandardLibrary.UInt.uint8> := [];
var d3 : Crypto.EncryptedDataKey := Crypto.EncryptedDataKey.EncryptedDataKey(keyProviderId:=d0,keyProviderInfo:=d1,ciphertext:=d2);
var r0 := v0.Invoke(d3);
}
method {:test} test1() {
var v0 := getFreshMaterialProvidersAwsKmsKeyringOnDecryptEncryptedDataKeyFilter();
var d0 : UTF8.ValidUTF8Bytes := [216, 162, 0, 0, 0, 0, 0];
var d1 : seq<StandardLibrary.UInt.uint8> := [];
var d2 : seq<StandardLibrary.UInt.uint8> := [];
var d3 : Crypto.EncryptedDataKey := Crypto.EncryptedDataKey.EncryptedDataKey(keyProviderId:=d0,keyProviderInfo:=d1,ciphertext:=d2);
var r0 := v0.Invoke(d3);
}
/*method {:test} test2() {
var v0 := getFreshMaterialProvidersAwsKmsKeyringAwsKmsKeyring();
var d0 : Aws.Crypto.AlgorithmSuiteId := Crypto.AlgorithmSuiteId.ALG_AES_128_GCM_IV12_TAG16_NO_KDF;
var d1 : Aws.Crypto.EncryptionContext := map[];
var d2 : Aws.Crypto.EncryptedDataKeyList := [];
var d3 : Wrappers.Option<seq<StandardLibrary.UInt.uint8>> := Wrappers.Option<seq<StandardLibrary.UInt.uint8>>.None;
var d4 : Wrappers.Option<seq<StandardLibrary.UInt.uint8>> := Wrappers.Option<seq<StandardLibrary.UInt.uint8>>.None;
var d5 : Aws.Crypto.EncryptionMaterials := Aws.Crypto.EncryptionMaterials.EncryptionMaterials(algorithmSuiteId:=d0,encryptionContext:=d1,encryptedDataKeys:=d2,plaintextDataKey:=d3,signingKey:=d4);
var d6 : Crypto.OnEncryptInput := Crypto.OnEncryptInput.OnEncryptInput(materials:=d5);
var r0 := v0.OnEncrypt(d6);
expect r0.Success? ==> true && MaterialProviders.Materials.EncryptionMaterialsTransitionIsValid(d6.materials, r0.value.materials);
expect MaterialProviders.AwsKmsKeyring.StringifyEncryptionContext(d6.materials.encryptionContext).Failure? ==> r0.Failure?;
expect !Com.Amazonaws.Kms.IsValid_KeyIdType(v0.awsKmsKey) ==> r0.Failure?;
expect d6.materials.plaintextDataKey.Some? && !Com.Amazonaws.Kms.IsValid_PlaintextType(d6.materials.plaintextDataKey.value) ==> r0.Failure?;
}*/

method {:synthesize} getFreshMaterialProvidersAwsKmsKeyringOnDecryptEncryptedDataKeyFilter() returns (o:MaterialProviders.AwsKmsKeyring.OnDecryptEncryptedDataKeyFilter) ensures fresh(o)
method {:synthesize} getFreshMaterialProvidersAwsKmsKeyringAwsKmsKeyring() returns (o:MaterialProviders.AwsKmsKeyring.AwsKmsKeyring) ensures fresh(o)
}
