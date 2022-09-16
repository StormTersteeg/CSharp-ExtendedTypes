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

Console.WriteLine(letters_combined);
Console.WriteLine(letters_uppercased);
Console.WriteLine(letters_count);