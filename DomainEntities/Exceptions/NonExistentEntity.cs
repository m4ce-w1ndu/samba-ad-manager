namespace DomainEntities.Exceptions
{
    /// <summary>
    /// This exception is thrown when the specified entity is non-existent 
    /// and an update or delete operation has been requested.
    /// </summary>
    public class NonExistentEntity : Exception
    {
        public NonExistentEntity() : base() { }

        public NonExistentEntity(string message) : base(message) { }
    }
}
