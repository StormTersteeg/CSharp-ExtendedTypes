using ExtendedList;

EList<string> letters = new EList<string>(){"a", "b", "c"};

string letters_combined = letters.Reduce(
    (t, i) => {t = t + i; return t;},
    ""
);
EList<string> letters_uppercased = letters.Reduce(
    (t, i) => { t.Add(i.ToUpper()); return t; },
    new EList<string>()
);
int letters_count = letters.Reduce(
    (t, i) => { t++; return t; },
    0
);
EList<string> letters_with_index = letters.Map(
    (i) => { return i + letters.IndexOf(i); }
);

Console.WriteLine(letters_combined);
Console.WriteLine(letters_uppercased);
Console.WriteLine(letters_count);
Console.WriteLine(letters_with_index);

EList<int> numbers = new EList<int>() { 1, 2, 3, 4, 5 };

int numbers_sum = numbers.Reduce(
    (t, i) => { t += i; return t; },
    0
);
int numbers_product = numbers.Reduce(
    (t, i) => { t *= i; return t; },
    1
);
int numbers_max = numbers.Reduce(
    (t, i) => { t = Math.Max(t, i); return t; },
    0
);
EList<int> numbers_times_two = numbers.Map(
    (i) => { return i * 2; }
);

Console.WriteLine(numbers_sum);
Console.WriteLine(numbers_product);
Console.WriteLine(numbers_max);
Console.WriteLine(numbers_times_two);