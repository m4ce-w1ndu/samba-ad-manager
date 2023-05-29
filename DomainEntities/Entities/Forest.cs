using DomainEntities.Interfaces;

namespace DomainEntities.Entities
{
    /// <summary>
    /// Represents a forest related with the current Active Directory installation
    /// </summary>
    public class Forest : IDomainEntity
    {
        public string CommonName { get; set; }
        public string OrganizationalUnit { get; set; }
        public string DomainComponent { get; set; }
        public string? VisibleName { get; set; }

        public Forest()
        {
            CommonName = string.Empty;
            OrganizationalUnit = string.Empty;
            DomainComponent = string.Empty;
            VisibleName = default;
        }

        public Forest(string cn, string ou, string dc)
        {
            CommonName = cn;
            OrganizationalUnit = ou;
            DomainComponent = dc;
            VisibleName = default;
        }

        public Forest(string commonName, string organizationalUnit, string domainComponent, string? visibleName) : this(commonName, organizationalUnit, domainComponent)
        {
            VisibleName = visibleName;
        }
    }
}
