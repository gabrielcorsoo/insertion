﻿﻿using System.Reflection.Metadata;
using Insercao;

string[] names = new string[3]{"Gabriel", "Corso", "Andrade"};

Insercao.InsertionSort.Sort(names);

foreach(string name in names)
    System.Console.WriteLine(name);