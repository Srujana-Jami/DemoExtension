using ExtenMethods.Lib;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtenMethods.Tests
{
    class ConfigTests
    {
        [Test]
        public void IsLoaded()
        {
            IConfiguration config = null;
            Assert.IsFalse(config.IsLoaded());
        }
        
        [Test]
        public void AddStandardProviders()
        {
            var builder = new ConfigurationBuilder();
            var config = builder.AddStandardProviders().Build();
            Assert.AreEqual(4, config.Providers.Count());
            Assert.IsTrue(config.IsLoaded());
        }

    }
}
