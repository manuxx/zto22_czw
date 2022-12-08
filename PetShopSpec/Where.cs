using System;

namespace Training.Specificaton
{
    internal class Where<TItem>
    {
        public static CriteriaBuilder<TItem,TProperty> HasAn<TProperty>(Func<TItem, TProperty> selector) 
        {
            return new CriteriaBuilder<TItem,TProperty>(selector);
        }
    }
}