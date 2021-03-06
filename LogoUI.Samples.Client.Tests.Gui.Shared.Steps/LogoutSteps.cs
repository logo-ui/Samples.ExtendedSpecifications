﻿using Attest.Fake.Moq;
using Attest.Tests.Specflow;
using TechTalk.SpecFlow;

namespace LogoUI.Samples.Client.Tests.Gui.Shared.Steps
{
    [Binding]
    class LogoutSteps : StepsBase<FakeFactory>
    {
        [Given(@"Logout request succeeds")]
        public void GivenLogoutRequestSucceeds()
        {
            //TODO: do nothing for now
            //think what should be the behavior in case of failed logout
        }

        [When(@"I press the logout button")]
        public void WhenIPressTheLogoutButton()
        {
            StructureHelper.GetShell().LogoutCommand.Execute(null);
        }
    }
}
