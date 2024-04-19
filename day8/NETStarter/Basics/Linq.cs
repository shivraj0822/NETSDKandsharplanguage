
// Language Integrated Query

// Imperative [Procedural, OOP etc.] (C, C++, C# etc.) vs Declarative [Functional] (SQL, Haskell, C#, Lisp etc. ) programming languages

using System.Collections.Generic;
using System.Linq;

class LINQ
{
    int[] ages = [23, 45, 67, 8, 9, 12, 345, 67, 889, 34, 56, 78];

    // Find squares of all numbers in ages collection

    public void LearnLinq()
    {
        // Imperative
        List<int> sqaures = [];
        foreach (var age in ages)
        {
            var square = age * ages;
            squares.Add(square);
        }
        // Declarative
        var squares =age.Select(age => age * age);
        // Find thecubes of all even number
        var cubesOfEven =age.Where(age =>age % 2 ==0).Select( age => age * age * age);

    }
}