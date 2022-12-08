using System;

namespace Training.Specificaton
{
    public class FilteringEntryPoint<TItem,TProperty> 
    {
        public readonly Func<TItem, TProperty> _selector;
        public readonly bool _negating;

        public FilteringEntryPoint(Func<TItem, TProperty> selector) : this(selector, false) 
        {
        }

        private FilteringEntryPoint(Func<TItem, TProperty> selector, bool negating)
        {
            _selector = selector;
            _negating = negating;
        }

        public FilteringEntryPoint<TItem,TProperty> Not()
        {

            return new FilteringEntryPoint<TItem, TProperty>(_selector, !_negating);
        }
    }
}