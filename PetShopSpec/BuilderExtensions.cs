using System;
using Training.Specificaton;

static internal class BuilderExtensions
{
    public static ICriteria<TItem> EqualTo<TItem, TProperty>(this CriteriaBuilder<TItem, TProperty> criteriaBuilder, TProperty species)
    {
        return new AnonymousCriteria<TItem>(pet=> criteriaBuilder._selector(pet).Equals(species));
    }

    public static ICriteria<TItem> GreaterThan<TItem, TProperty>(this CriteriaBuilder<TItem, TProperty> criteriaBuilder, TProperty value) 
        where TProperty : IComparable<TProperty>
    {
        return new AnonymousCriteria<TItem>(pet => criteriaBuilder._selector(pet).CompareTo(value) > 0);
    }
}