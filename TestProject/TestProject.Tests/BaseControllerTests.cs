using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using NUnit.Framework;
using TestProject.Services;

namespace TestProject.Tests
{
    public abstract class BaseControllerTests
    {   
        protected Mock<ICarService> CarServiceMock { get; set; }

        [SetUp]
        public void SetUp()
        {
            // Tests here
        }
    }
}
