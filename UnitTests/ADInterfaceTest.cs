using ADInterface.Connection;

namespace UnitTests
{
    public class ADInterfaceTest
    {
        /// <summary>
        /// Change this to run tests on your network
        /// </summary>
        const string AD_SERVER = "10.3.27.0";

        /// <summary>
        /// Active Directory Domain
        /// </summary>
        const string AD_DOMAIN = "FERRPANC";

        /// <summary>
        /// Active Directory administrator account for tests.
        /// REMOVE THIS FROM CODE BEFORE COMMIT!
        /// </summary>
        const string AD_ADMIN = "networkuser";

        /// <summary>
        /// Active Directory administrator user password for tests.
        /// REMOVE THIS FROM CODE BEFORE COMMIT!
        /// </summary>
        const string AD_PASS = "Palichi17";

        [Fact]
        public void EstablishConnection_GoodServer()
        {
            var connMan = ADConnectionManager.GetInstance();
            var connection = connMan.GetConnection(AD_SERVER, AD_DOMAIN, AD_ADMIN, AD_PASS, true);

            Assert.NotNull(connection);

            connMan.Close();
        }
    }
}
