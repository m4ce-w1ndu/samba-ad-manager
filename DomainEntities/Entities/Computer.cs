using DomainEntities.Interfaces;

namespace DomainEntities.Entities
{
    public class Computer : IDomainEntity, IManageableEntity
    {
        public string CommonName { get; set; }

        public string OrganizationalUnit { get; set; }

        public string DomainComponent { get; set; }

        public string? VisibleName { get; set; }

        public Domain Domain { get; set; }

        public Computer(string cn, string ou, string dc, string visibleName, Domain domain)
        {
            CommonName = cn;
            OrganizationalUnit = ou;
            DomainComponent = dc;
            VisibleName = visibleName;
            Domain = domain;
        }

        public bool Add()
        {
            throw new NotImplementedException();
        }

        public bool Remove()
        {
            throw new NotImplementedException();
        }

        public bool Update()
        {
            throw new NotImplementedException();
        }
    }
}
