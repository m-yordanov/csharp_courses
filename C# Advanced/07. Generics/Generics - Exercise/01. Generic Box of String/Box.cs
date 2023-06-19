﻿using System.Text;

namespace GenericBoxOfString;
public class Box<T>
{
    private List<T> items = new();
    
    public void Add(T item)
    {
        items.Add(item);
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        foreach(T item in items)
        {
            sb.AppendLine($"{typeof(T)}: {item}");
        }

        return sb.ToString().TrimEnd();
    }
}
