using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cake.Common.Build.VSTS;
using Cake.Core;
using NSubstitute;

namespace Cake.Common.Tests.Fixtures.Build
{
    internal sealed class VSTSFixture
    {
        public ICakeEnvironment Environment { get; set; }

        public VSTSFixture()
        {
            Environment = Substitute.For<ICakeEnvironment>();
            Environment.WorkingDirectory.Returns("C:\\build\\CAKE-CAKE-JOB1");
            Environment.GetEnvironmentVariable("TF_BUILD").Returns((string)null);
        }

        public void IsRunningOnVSTS()
        {
            Environment.GetEnvironmentVariable("TF_BUILD").Returns("True");
        }

        public VSTSProvider CreateVSTSService()
        {
            return new VSTSProvider(Environment);
        }
    }
}
