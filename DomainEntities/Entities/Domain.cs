using DomainEntities.Interfaces;

namespace DomainEntities.Entities
{
    /// <summary>
    /// Represents an Active Directory domain enabled and active in the current installation
    /// </summary>
    public class Domain : IDomainEntity
    {
        public string CommonName { get; set; }
        public string OrganizationalUnit { get; set; }
        public string DomainComponent { get; set; }

        public string? VisibleName { get; set; }

        /// <summary>
        /// Domain linked (parent) forest
        /// </summary>
        public Forest Forest { get; set; }

        /// <summary>
        /// This domain's NETBIOS name
        /// </summary>
        public string NetbiosName { get; set; }
        
        public Domain(Forest forest)
        {
            CommonName = string.Empty;
            OrganizationalUnit = string.Empty;
            DomainComponent = string.Empty;
            VisibleName = default;
            NetbiosName = string.Empty;
            Forest = forest;
        }

        public Domain(Forest forest, string cn, string ou, string dc)
        {
            CommonName = cn;
            OrganizationalUnit = ou;
            DomainComponent = dc;
            VisibleName = default;
            NetbiosName = string.Empty;
            Forest = forest;
        }

        public Domain(Forest forest, string cn, string ou, string dc, string? visibleName) : this(forest, cn, ou, dc)
        {
            VisibleName = visibleName;
        }

        public Domain(Forest forest, string cn, string ou, string dc, string? visibleName, string netbiosName) : this(forest, cn, ou, dc, visibleName)
        {
            NetbiosName = netbiosName;
        }
    }
}
