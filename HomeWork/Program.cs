int[] arr =  { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};

int target = 24;

Console.WriteLine("Первый вариант:");
#region First option
var s = new HashSet<int>();
foreach (var i in arr)
{
    var s1 = target - i;

    foreach (var j in arr)
    {
        var s2 = s1 - j;

        if (s.Contains(s2))
        {
            Console.WriteLine($"{target} = {s2} + {j} + {i}");
        }
        else
        {
            s.Add(i);
        }
    }
}
#endregion
Console.WriteLine("Второй вариант:");

#region Second option
var triplets = from a in arr
               from b in arr
               from c in arr
               where a + b + c == target
               select new { A = a, B = b, C = c };

if (triplets.Any())
{
    var firstTriplet = triplets.First();
    Console.WriteLine($"{target} = {firstTriplet.A} + {firstTriplet.B} + {firstTriplet.C}");
}
else
{
    Console.WriteLine("Не найдено");
}
#endregion