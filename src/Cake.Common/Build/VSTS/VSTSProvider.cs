// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using Cake.Common.Build.VSTS.Data;
using Cake.Core;

namespace Cake.Common.Build.VSTS
{
    /// <summary>
    /// Responsible for communicating with VSTS.
    /// </summary>
    public sealed class VSTSProvider : IVSTSProvider
    {
        private readonly ICakeEnvironment _environment;

        /// <summary>
        /// Initializes a new instance of the <see cref="VSTSProvider"/> class.
        /// </summary>
        /// <param name="environment">The environment.</param>
        public VSTSProvider(ICakeEnvironment environment)
        {
            if (environment == null)
            {
                throw new ArgumentNullException(nameof(environment));
            }
            _environment = environment;
            Environment = new VSTSEnvironmentInfo(environment);
        }

        /// <summary>
        /// Gets a value indicating whether the current build is running on VSTS.
        /// </summary>
        /// <value>
        /// <c>true</c> if the current build is running on VSTS; otherwise, <c>false</c>.
        /// </value>
        public bool IsRunningOnVSTS => !string.IsNullOrWhiteSpace(_environment.GetEnvironmentVariable("TF_BUILD"));

        /// <summary>
        /// Gets the VSTS environment.
        /// </summary>
        /// <value>
        /// The VSTS environment.
        /// </value>
        public VSTSEnvironmentInfo Environment { get; }
    }
}
