using System.Text;
using System;
using System.Linq;

public class Kata

{
    public static string[] TowerBuilder(int nFloors)
    {
        string[] strings = new string[nFloors];

        for (int i = 0; i < nFloors; i++)
        {
            strings[i] = string.Concat(Enumerable.Repeat(" ", (nFloors - i) - 1)) + string.Concat(Enumerable.Repeat("*", (i + 1) * 2 - 1)) + string.Concat(Enumerable.Repeat(" ", (nFloors - i) - 1));
        }
        return strings;
    }
}