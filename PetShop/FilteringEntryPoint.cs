using System;
using Training.DomainClasses;

namespace Training.Specificaton
{
    public class FilteringEntryPoint<TItem,TProperty> 
    {
        public readonly Func<TItem, TProperty> _selector;
        private readonly bool _negating;

        public FilteringEntryPoint(Func<TItem, TProperty> selector) : this(selector, false) 
        {
        }

        private FilteringEntryPoint(Func<TItem, TProperty> selector, bool negating)
        {
            _selector = selector;
            _negating = negating;
        }

        public FilteringEntryPoint<TItem, TProperty> Not()
        {

            return new FilteringEntryPoint<TItem, TProperty>(_selector, !_negating);
        }

        public ICriteria<TItem> ApplyNegating(ICriteria<TItem> resultCriteria)
        {
            if (_negating)
                return new Negation<TItem>(resultCriteria);
            else
                return resultCriteria;
        }
    }
}