using System;
using System.Diagnostics;

void Test(int mark)
{
    string letterGrade = mark switch
    {
        >= 85 => "hd",
        >= 75 => "D",
        >= 65 => "C",
        >= 50 => "P",
        _ => "N"
    };

    Console.WriteLine(letterGrade);
}

void Test2(int mark)
{
    string letterGrade = "";
    if ((mark >= 85))
        letterGrade = "hd";
    else if (mark >= 75)
        letterGrade = "D";
    else if ((mark >= 65))
        letterGrade = "C";
    else if ((mark >= 50))
        letterGrade = "P";
    else
        letterGrade = "N";

    Console.WriteLine(letterGrade);
}

Test(64);
Test2(64);