// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Cake.Common.Build.VSTS;
using Cake.Common.Tests.Fixtures.Build;
using Xunit;

namespace Cake.Common.Tests.Unit.Build.VSTS
{
    public sealed class VSTSProviderTests
    {
        public sealed class TheConstructor
        {
            [Fact]
            public void Should_Throw_If_Environment_Is_Null()
            {
                // Given, When
                var result = Record.Exception(() => new VSTSProvider(null));

                // Then
                Assert.IsArgumentNullException(result, "environment");
            }
        }

        public sealed class TheIsRunningOnVSTSProperty
        {
            [Fact]
            public void Should_Return_True_If_Running_On_VSTS()
            {
                // Given
                var fixture = new VSTSFixture();
                fixture.IsRunningOnVSTS();
                var vsts = fixture.CreateVSTSService();

                // When
                var result = vsts.IsRunningOnVSTS;

                // Then
                Assert.True(result);
            }

            [Fact]
            public void Should_Return_False_If_Not_Running_On_VSTS()
            {
                // Given
                var fixture = new VSTSFixture();
                var vsts = fixture.CreateVSTSService();

                // When
                var result = vsts.IsRunningOnVSTS;

                // Then
                Assert.False(result);
            }
        }

        public sealed class TheEnvironmentProperty
        {
            [Fact]
            public void Should_Return_Non_Null_Reference()
            {
                // Given
                var fixture = new VSTSFixture();
                var vsts = fixture.CreateVSTSService();

                // When
                var result = vsts.Environment;

                // Then
                Assert.NotNull(result);
            }
        }
    }
}
