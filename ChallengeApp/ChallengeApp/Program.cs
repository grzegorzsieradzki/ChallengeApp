﻿string name = "Ewa";
string sex = "kobieta";
int age = 30;

if (sex == "kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (sex == "mężczyzna" && age < 18)
{
    Console.WriteLine("Niepelnoletni mężczyzna");
}