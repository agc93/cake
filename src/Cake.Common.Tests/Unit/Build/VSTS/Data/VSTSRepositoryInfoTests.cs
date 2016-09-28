// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Cake.Common.Build.VSTS.Data;
using Cake.Common.Tests.Fixtures.Build;
using Xunit;

namespace Cake.Common.Tests.Unit.Build.VSTS.Data
{
    public sealed class VSTSRepositoryInfoTests
    {
        public sealed class TheBranchProperty
        {
            [Fact]
            public void Should_Return_Correct_Value()
            {
                // Given
                var info = new VSTSInfoFixture().CreateRepositoryInfo();

                // When
                var result = info.Branch;

                // Then
                Assert.Equal("develop", result);
            }
        }

        public sealed class TheSourceVersionProperty
        {
            [Fact]
            public void Should_Return_Correct_Value()
            {
                // Given
                var info = new VSTSInfoFixture().CreateRepositoryInfo();

                // When
                var result = info.SourceVersion;

                // Then
                Assert.Equal("4efbc1ffb993dfbcf024e6a9202865cc0b6d9c50", result);
            }
        }

        public sealed class TheShelvesetProperty
        {
            [Fact]
            public void Should_Return_Correct_Value()
            {
                // Given
                var info = new VSTSInfoFixture().CreateRepositoryInfo();

                // When
                var result = info.Shelveset;

                // Then
                Assert.Equal("Shelveset1", result);
            }
        }

        public sealed class TheRepoNameProperty
        {
            [Fact]
            public void Should_Return_Correct_Value()
            {
                // Given
                var info = new VSTSInfoFixture().CreateRepositoryInfo();

                // When
                var result = info.RepoName;

                // Then
                Assert.Equal("cake", result);
            }
        }

        public sealed class TheProviderProperty
        {
            [Theory]
            [InlineData("Git", VSTSRepositoryType.Git)]
            [InlineData("GitHub", VSTSRepositoryType.GitHub)]
            [InlineData("Svn", VSTSRepositoryType.Svn)]
            [InlineData("TfsGit", VSTSRepositoryType.TfsGit)]
            [InlineData("TfsVersionControl", VSTSRepositoryType.TfsVersionControl)]
            public void Should_Return_Correct_Value(string type, VSTSRepositoryType provider)
            {
                // Given
                var info = new VSTSInfoFixture().CreateRepositoryInfo(type);

                // When
                var result = info.Provider;

                // Then
                Assert.Equal(provider, result);
            }
        }
    }
}
