// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Cake.Common.Build.VSTS.Data;

namespace Cake.Common.Build.VSTS
{
    /// <summary>
    /// Represents a VSTS provider.
    /// </summary>
    public interface IVSTSProvider
    {
        /// <summary>
        /// Gets a value indicating whether the current build is running on VSTS.
        /// </summary>
        /// <value>
        /// <c>true</c> if the current build is running on VSTS; otherwise, <c>false</c>.
        /// </value>
        bool IsRunningOnVSTS { get; }

        /// <summary>
        /// Gets the VSTS environment.
        /// </summary>
        /// <value>
        /// The VSTS environment.
        /// </value>
        VSTSEnvironmentInfo Environment { get; }
    }
}
