using DomainEntities.Exceptions;

namespace DomainEntities.Interfaces
{
    public interface IManageableEntity
    {
        /// <summary>
        /// Adds this entity to the current domain
        /// </summary>
        /// <returns>true if successful, false otherwise</returns>
        public bool Add();

        /// <summary>
        /// Removes this entity from the current domain
        /// </summary>
        /// <returns>true if successful, false otherwise</returns>
        /// <exception cref="NonExistentEntity">Thrown when an entity is non-existent</exception>
        public bool Remove();

        /// <summary>
        /// Updates this entity in the current domain
        /// </summary>
        /// <exception cref="NonExistentEntity">Thrown when an entity is non-existent</exception>
        public bool Update();
    }
}
