using System;
using System.Collections.Generic;
using Domain;
using Xunit;

namespace Test
{
    public class Championship_Test
    {
        [Fact]
        public void should_not_create_candidates_when_password_is_incorrect()
        {
            // Dado / Setup
            var championship = new Championship();
            var jose = new Register("José","Fan");
            var user = new List<Register>{jose};

            // Quando / Ação
            var created = championship.CreateUser(user, "incorrect");

            // Deve / Asserções
            Assert.Empty(Championship.user);
            Assert.False(created);
        }
    }
}
