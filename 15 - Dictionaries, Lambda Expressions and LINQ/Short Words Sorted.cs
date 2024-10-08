﻿char[] separators = " .,:;()[]\"'!? ".ToCharArray();
var words = Console.ReadLine().ToLower().Split(separators);
var result = words
    .Where(w => w != "")
    .Where(w => w.Length < 5)
    .OrderBy(w => w) 
    .Distinct();
Console.WriteLine(string.Join(", ", result));