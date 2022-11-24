using System;
using System.Collections.Generic;
using System.Linq;
using Training.DomainClasses;

static internal class EnumerableTools
{
    public static IEnumerable<TItem> OneAtATime<TItem>(this IEnumerable<TItem> items)
    {
        foreach (var item in items)
        {
            yield return item;
        }
    }

    public static IEnumerable<TItem> AllThat<TItem>(this IEnumerable<TItem> items, Predicate<TItem> condition)
    {
        return items.AllThat(new AnonymousCriteria<TItem>(condition));
    }

    public static IEnumerable<TItem> AllThat<TItem>(this IEnumerable<TItem> items, Criteria<TItem> criteria)
    {
        foreach (var item in items)
        {
            if (criteria.IsSatisfiedBy(item))
            {
                yield return item;
            }
        }
    }
}

internal class AnonymousCriteria<T> :Criteria<T>
{
    public AnonymousCriteria(Predicate<T> condition)
    {
        throw new NotImplementedException();
    }

    public bool IsSatisfiedBy(T pet)
    {
        throw new NotImplementedException();
    }
}

public interface Criteria<TItem>
{
    bool IsSatisfiedBy(TItem pet);
}