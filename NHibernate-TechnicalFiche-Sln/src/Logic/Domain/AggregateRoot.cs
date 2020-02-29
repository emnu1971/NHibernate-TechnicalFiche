namespace Logic.Domain
{
    public abstract class AggregateRoot : Entity
    {
        // used for optimistic concurrency
        public virtual int Version { get; protected set; }
    }
}
