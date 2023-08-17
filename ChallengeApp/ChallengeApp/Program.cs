int number = 2911;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

for (int i = 0; i < 10; i++)
{
    int counter = 0;
    foreach (char letter in letters)
    {
        int charInNumber = letter - '0';
        if (charInNumber == i)
        {
            counter++;
        }
    }
    Console.WriteLine(i + "=>" + counter);
}
