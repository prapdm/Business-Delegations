using Delegations;
using NUnit.Framework;


namespace DelegationUnitTest
{
    class PasswordHasherTest
    {
        [Test]
        public void HashedPassowrds_ShouldBeDifrent()
        {
            var password_hasher = new PasswordHasher();
            var hashed_1 = password_hasher.Hash("MojeHaslo123");
            var hashed_2 = password_hasher.Hash("MojeHaslo123");
            Assert.AreNotSame(hashed_1, hashed_2);
        }

        [Test]
        public void Compare_HashedPassword_To_EnteredPassword_ShouldBeTrue()
        {
            string enteredPassword = "MojeHaslo123";
            var password_hasher = new PasswordHasher();
            var hashed = password_hasher.Hash(enteredPassword);
            var compare = password_hasher.ComparePassword(enteredPassword, hashed);
            Assert.IsTrue(compare);

        }
    }
}
