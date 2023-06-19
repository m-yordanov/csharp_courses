﻿using System.Text;
namespace GenericMethodCountDouble;

public class Box<T> where T : IComparable<T>
{
    private List<T> items = new();

    public void Add(T item)
    {
        items.Add(item);
    }

    public int Count(T itemToCompare)
    {
        int count = 0;

        foreach (T item in items)
        {
            if (item.CompareTo(itemToCompare) > 0)
            {
                count++;
            }
        }

        return count;
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        foreach (T item in items)
        {
            sb.AppendLine($"{typeof(T)}: {item}");
        }

        return sb.ToString().TrimEnd();
    }
}
