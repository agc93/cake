// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Cake.Core;

namespace Cake.Common.Build.VSTS.Data
{
    /// <summary>
    /// Provides VSTS Environment information for the current build.
    /// </summary>
    public sealed class VSTSEnvironmentInfo : VSTSInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VSTSEnvironmentInfo"/> class.
        /// </summary>
        /// <param name="environment">The environment.</param>
        public VSTSEnvironmentInfo(ICakeEnvironment environment)
            : base(environment)
        {
            Repository = new VSTSRepositoryInfo(environment);
            BuildDefinition = new VSTSDefinitionInfo(environment);
            Build = new VSTSBuildInfo(environment);
            Agent = new VSTSAgentInfo(environment);
            TeamProject = new VSTSTeamProjectInfo(environment);
        }

        /// <summary>
        /// Gets VSTS repository information
        /// </summary>
        /// <value>
        /// The VSTS repository information.
        /// </value>
        public VSTSRepositoryInfo Repository { get; }

        /// <summary>
        /// Gets VSTS Build Definition information.
        /// </summary>
        /// <value>
        /// The VSTS Build Definition.
        /// </value>
        public VSTSDefinitionInfo BuildDefinition { get; }

        /// <summary>
        /// Gets VSTS Build information.
        /// </summary>
        /// <value>
        /// The VSTS Build.
        /// </value>
        public VSTSBuildInfo Build { get; }

        /// <summary>
        /// Gets VSTS Team Project information.
        /// </summary>
        /// <value>
        /// The VSTS Team Project.
        /// </value>
        public VSTSTeamProjectInfo TeamProject { get; }

        /// <summary>
        /// Gets VSTS Build agent information.
        /// </summary>
        /// <value>
        /// The VSTS Build agent.
        /// </value>
        public VSTSAgentInfo Agent { get; }
    }
}
