namespace Acme.BL.Entities
{
    public enum EntityStateOptions
    {
        Active,
        Deleted
    }

    /// <summary>
    /// Base class for all Acme entities.
    /// </summary>
    public abstract class EntityBase
    {
        /// <summary>
        /// The entity is new.
        /// </summary>
        public bool IsNew { get; private set; }

        /// <summary>
        /// Changes have occured.
        /// </summary>
        public bool HasChanges { get; set; }

        /// <summary>
        /// Active or soft-deleted.
        /// </summary>
        public EntityStateOptions Base { get; set; }

        /// <summary>
        /// Checks if entity is valid by invoking Validate.
        /// </summary>
        public bool IsValid => Validate();

        // Derived classes MUST implement this. Virtual would allow for a default
        // implementation but does require a method body.
        public abstract bool Validate();
    }
}
