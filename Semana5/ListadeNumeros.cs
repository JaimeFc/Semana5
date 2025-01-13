using System;
using System.Collections.Generic;

public class ListManager
{
    private List<int> numbers;

    public ListManager()
    {
        numbers = new List<int>();
        for (int i = 1; i <= 10; i++)
        {
            numbers.Add(i);
        }
    }

    public string GetReversedList()
    {
        numbers.Reverse();
        return string.Join(", ", numbers);
    }
}
