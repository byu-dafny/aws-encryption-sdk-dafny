# AWS Encryption SDK Written in Dafny

![Build Status - master branch](https://codebuild.us-west-2.amazonaws.com/badges?uuid=eyJlbmNyeXB0ZWREYXRhIjoiVmIzeGwwQmY5bXdMQXg2aVBneWtDc3FHSWRHTjYrNnVUem9nNXJFUmY2Rk1yRnJvSjJvK3JCL2RScFRjSVF1UjA1elR3L0xpTVpiNmRZS0RyWjJpTnBFPSIsIml2UGFyYW1ldGVyU3BlYyI6InBBQm1tT1BPNjB3RU9XUS8iLCJtYXRlcmlhbFNldFNlcmlhbCI6MX0%3D&branch=master)

AWS Encryption SDK Written in Dafny for .NET

[Security issue notifications](./CONTRIBUTING.md#security-issue-notifications)

## Using the AWS Encryption SDK for .NET
The AWS Encryption SDK is available on [NuGet](https://www.nuget.org/) and can referenced from an existing `.csproj` through typical ways.

```
<!-- TODO: Update with actual NuGet package name, the name below is just an example -->
<PackageReference Include="AWS.EncryptionSDK" />
```

The Encryption SDK source has a target framework of [netstandard2.0](https://docs.microsoft.com/en-us/dotnet/standard/net-standard).

## Building the AWS Encryption SDK Written in Dafny

To build, the AWS Encryption SDK requires the most up to date version of [dafny](https://github.com/dafny-lang/dafny) on your PATH.

The Encryption SDK source has a target framework of [netstandard2.0](https://docs.microsoft.com/en-us/dotnet/standard/net-standard).
Tests and test vectors have a target framework of [netcoreapp3.0](https://docs.microsoft.com/en-us/dotnet/standard/frameworks), which is required for properly building and running tests.
Therefore, building and verifying requires [dotnet 3.0](https://dotnet.microsoft.com/download/dotnet-core/3.0).

To build all source files into one dll:

```
dotnet build
```

To run the dafny verifier across all files:

```
# Currently, test depends on src, so verifying test will also verify src
dotnet build -t:VerifyDafny test
```

### (Optional) Set up the AWS Encryption SDK to work with AWS KMS

If you set up the AWS Encryption SDK to use the AWS KMS Keyring,
the AWS Encryption SDK will make calls to AWS KMS on your behalf,
using the appropriate AWS SDK.

However, you must first set up AWS credentials for use with the AWS SDK.

Instructions for setting up AWS credentials are available in the AWS Docs for the AWS SDK in your language:

- [.NET](https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/net-dg-config-creds.html)

## Testing the AWS Encryption SDK Written in Dafny

### Configure AWS credentials

To run the test suite you must first set up AWS credentials for use with the AWS SDK.
This is required in order to run the integration tests, which use a KMS Keyring against a publicaly accessible KMS CMK.

Instructions for setting up AWS credentials are available in the AWS Docs for the AWS SDK in your language:

- [.NET](https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/net-dg-config-creds.html)

### Run the tests

Run the test suite with:

```
dotnet test
```

You can see more detail about what test cases are being run by increasing the verbosity:

```
dotnet test --logger:"console;verbosity=normal"
```

Run the test vector suite after [set up](testVector/README.md) with:

```
dotnet test testVectors
```

Run tests on examples, to ensure they are up to date:

```
dotnet test examples/dotnet
```

Please note that tests and test vectors require internet access and valid AWS credentials, since calls to KMS are made as part of the test workflow.

## License

This library is licensed under the Apache 2.0 License.
