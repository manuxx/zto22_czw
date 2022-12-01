namespace Training.DomainClasses
{
    public class Negation<TItem> : ICriteria<TItem>
    {
        private readonly ICriteria<TItem> _innerCriteria;

        public Negation(ICriteria<TItem> innerCriteria)
        {
            _innerCriteria = innerCriteria;
        }

        public bool IsSatisfiedBy(TItem item)
        {
            return ! _innerCriteria.IsSatisfiedBy(item);
        }
    }
}