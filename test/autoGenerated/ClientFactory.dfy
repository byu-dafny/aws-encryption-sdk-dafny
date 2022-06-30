include "../../src//AwsCryptographicMaterialProviders/ClientFactory.dfy"
module ClientFactoryUnitTests {
import StandardLibrary
import StandardLibrary.UInt
import StandardLibrary.String
import Wrappers
import UTF8
import AESEncryption
import RSAEncryption
import Seq
import AwsKmsArnParsing
import AwsKmsMrkAreUnique
import AwsKmsUtils
import Math
import HMAC
import Signature
import Base64
import Defaults
import Actions
import Constants
import AwsKmsMrkMatchForDecrypt
import Random
import ExternRandom
import Streams
import MaterialProviders
import MaterialProviders.ClientFactory
import MaterialProviders.Client
import MaterialProviders.AlgorithmSuites
import MaterialProviders.DefaultClientSupplier
import MaterialProviders.DefaultCMM
import MaterialProviders.AwsKmsDiscoveryKeyring
import MaterialProviders.AwsKmsMrkKeyring
import MaterialProviders.AwsKmsMrkDiscoveryKeyring
import MaterialProviders.AwsKmsKeyring
import MaterialProviders.MultiKeyring
import MaterialProviders.RawAESKeyring
import MaterialProviders.RawRSAKeyring
import MaterialProviders.Materials
import MaterialProviders.CMM
import MaterialProviders.Commitment
import MaterialProviders.Keyring
import Aws
import Aws.Crypto
import Com
import Com.Amazonaws
import Com.Amazonaws.Kms
method {:test} test0() {
var v0 := getFreshMaterialProvidersClientFactoryAwsCryptographicMaterialProvidersFactory();
var r0 := v0.CreateDefaultAwsCryptographicMaterialProviders();
}

method {:synthesize} getFreshMaterialProvidersClientFactoryAwsCryptographicMaterialProvidersFactory() returns (o:MaterialProviders.ClientFactory.AwsCryptographicMaterialProvidersFactory) ensures fresh(o)
}