using System;

namespace Training.Specificaton
{
    public class FilteringEntryPoint<TItem,TProperty> 
    {
        public readonly Func<TItem, TProperty> _selector;
        public bool _negting;

        public FilteringEntryPoint(Func<TItem, TProperty> selector)
        {
            _selector = selector;
        }

        public FilteringEntryPoint<TItem,TProperty> Not()
        {
            _negting = true;
            return this;
        }
    }
}