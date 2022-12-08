using System;
using Training.DomainClasses;
using Training.Specificaton;

public static class FilteringEntryPointExtensions
{
    public static ICriteria<TItem> EqualTo<TItem, TProperty>(this FilteringEntryPoint<TItem, TProperty> filteringEntryPoint, TProperty species)
    {
        ICriteria<TItem> resultCriteria = new AnonymousCriteria<TItem>(item=> filteringEntryPoint._selector(item).Equals(species) );
        return AplyNegating(filteringEntryPoint, resultCriteria);
    }

    private static ICriteria<TItem> AplyNegating<TItem, TProperty>(FilteringEntryPoint<TItem, TProperty> filteringEntryPoint,
        ICriteria<TItem> resultCriteria)
    {
        if (filteringEntryPoint._negating)
            return new Negation<TItem>(resultCriteria);
        else
            return resultCriteria;
    }

    public static ICriteria<TItem> GreaterThan<TItem, TProperty>(this FilteringEntryPoint<TItem, TProperty> filteringEntryPoint, TProperty value) 
        where TProperty : IComparable<TProperty>
    {
        var resultCriteria = new AnonymousCriteria<TItem>(item => filteringEntryPoint._selector(item).CompareTo(value) > 0);
        return AplyNegating(filteringEntryPoint, resultCriteria);
    }
}