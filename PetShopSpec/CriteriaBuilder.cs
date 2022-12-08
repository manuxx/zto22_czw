using System;

namespace Training.Specificaton
{
    internal class CriteriaBuilder<TItem,TProperty> 
    {
        public readonly Func<TItem, TProperty> _selector;

        public CriteriaBuilder(Func<TItem, TProperty> selector)
        {
            _selector = selector;
        }
    }
}