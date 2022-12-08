using System;
using Training.Specificaton;

public static class FilteringEntryPointExtensions
{
    public static ICriteria<TItem> EqualTo<TItem, TProperty>(this FilteringEntryPoint<TItem, TProperty> filteringEntryPoint, TProperty species)
    {
        return new AnonymousCriteria<TItem>(item=> filteringEntryPoint._selector(item).Equals(species) != filteringEntryPoint._negting);
    }

    public static ICriteria<TItem> GreaterThan<TItem, TProperty>(this FilteringEntryPoint<TItem, TProperty> filteringEntryPoint, TProperty value) 
        where TProperty : IComparable<TProperty>
    {
        return new AnonymousCriteria<TItem>(item => filteringEntryPoint._selector(item).CompareTo(value) > 0);
    }
}