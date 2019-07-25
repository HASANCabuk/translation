﻿using NUnit.Framework;
using Shouldly;

using Translation.Client.Web.Models.Integration;
using static Translation.Tests.TestHelpers.FakeModelTestHelper;
using static Translation.Tests.TestHelpers.FakeConstantTestHelper;

namespace Translation.Tests.Client.Models.ViewModels.Integration
{
    [TestFixture]
    public class IntegrationActiveTokensModelTests
    {
        public IntegrationActiveTokensModel SystemUnderTest { get; set; }

        [SetUp]
        public void run_before_every_test()
        {
            SystemUnderTest = GetIntegrationActiveTokensModel(UidOne, StringOne);
        }

        [Test]
        public void IntegrationActiveTokensModel_Title()
        {
            Assert.AreEqual(SystemUnderTest.Title, "active_tokens_title");
        }

        [Test]
        public void IntegrationActiveTokensModel_Parameters()
        {
            SystemUnderTest.IntegrationUid.ShouldBe(UidOne);
            SystemUnderTest.IntegrationName.ShouldBe(StringOne);
        }
    }
}
