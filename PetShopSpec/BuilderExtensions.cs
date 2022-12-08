using System;
using Training.Specificaton;

static internal class BuilderExtensions
{
    public static ICriteria<TItem> EqualTo<TItem, TProperty>(this CriteriaBuilder<TItem, TProperty> criteriaBuilder, TProperty species)
    {
        return new AnonymousCriteria<TItem>(pet=> criteriaBuilder._selector(pet).Equals(species));
    }

    public static ICriteria<TItem> GreaterThan<TComparablePropert, TItem, TProperty>(this CriteriaBuilder<TItem, TProperty> criteriaBuilder, TComparablePropert value) 
        where TComparablePropert : IComparable<TProperty>

    {
        return new AnonymousCriteria<TItem>(pet => value.CompareTo(criteriaBuilder._selector(pet)) < 0);
    }
}