using Novell.Directory.Ldap;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace ADInterface.Connection
{
    /// <summary>
    /// Active Directory connection manager allows to manage
    /// the Active Directory connection to the server
    /// </summary>
    public class ADConnectionManager
    {
        /// <summary>
        /// Active Directory default LDAP port
        /// </summary>
        public const int DEFAULT_PORT = 389;

        /// <summary>
        /// Active Directory default LDAP ssl port
        /// </summary>
        public const int DEFAULT_SSL_PORT = 636;

        /// <summary>
        /// Server URL
        /// </summary>
        public string Server { get; set; }

        /// <summary>
        /// Server port
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// LDAP connection to the AD server
        /// </summary>
        private LdapConnection? ldapConnection;

        /// <summary>
        /// Instance of this connection manager
        /// </summary>
        private readonly static ADConnectionManager? instance;

        private ADConnectionManager()
        {
            Server = string.Empty;
        }

        /// <summary>
        /// Get the instance of the connection manager
        /// </summary>
        /// <returns><see cref="ADConnectionManager"/> static instance</returns>
        public static ADConnectionManager GetInstance()
        {
            if (instance is null) return new ADConnectionManager();
            return instance;
        }

        /// <summary>
        /// Get a new connection to the AD server
        /// </summary>
        /// <param name="server">Server IP address</param>
        /// <param name="username">Administrator user name</param>
        /// <param name="password">Administrator user password</param>
        /// <param name="port">Server port</param>
        /// <returns><see cref="LdapConnection"/> to the AD server</returns>
        public LdapConnection GetConnection(string server, string domain, string username, string password, bool ssl, int port = DEFAULT_PORT)
        {
            if (ldapConnection is not null) return ldapConnection;

            Server = server;
            Port = ssl ? DEFAULT_SSL_PORT : port;

            ldapConnection = ssl ? new LdapConnection(new LdapConnectionOptions().ConfigureRemoteCertificateValidationCallback((a, b, c, d) => true))
            {
                SecureSocketLayer = true
            } : new LdapConnection();

            ldapConnection.Connect(Server, Port);
            ldapConnection.Bind($"{domain}\\{username}", password);

            return ldapConnection;
        }

        /// <summary>
        /// Closes the LDAP connection (if present)
        /// </summary>
        public void Close()
        {
            if (ldapConnection is null) return;
            ldapConnection.Disconnect();
            ldapConnection.Dispose();
            ldapConnection = null;
        }

        /// <summary>
        /// This method bypasses the security certificate for AD connection
        /// </summary>
        private static bool IgnoreCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }
    }
}
