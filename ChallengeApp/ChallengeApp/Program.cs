string name = "Ewa";
string sex = "Kobieta";
int age = 30;

if (age < 30 && sex == "kobieta")
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa lat 33");
}
else if (age < 18 && sex != "kobieta")
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else if (age > 18 && sex != "kobieta")
{
    Console.WriteLine("Pełnoletni mężczyzna")
}