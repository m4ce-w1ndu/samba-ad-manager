namespace DomainEntities.Interfaces
{
    public interface IDomainEntity
    {
        /// <summary>
        /// Holds all the common names related with this entity
        /// </summary>
        public string CommonName { get; set; }

        /// <summary>
        /// Holds all the organizational units related with this entity
        /// </summary>
        public string OrganizationalUnit { get; set; }

        /// <summary>
        /// Holds all the domain components related with this entity
        /// </summary>
        public string DomainComponent { get; set; }

        /// <summary>
        /// Holds the visible name related with this entity
        /// </summary>
        public string? VisibleName { get; set; }
    }
}
