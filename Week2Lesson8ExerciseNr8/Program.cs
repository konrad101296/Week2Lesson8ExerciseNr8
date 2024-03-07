Console.WriteLine("enter a string of characters: ");
string characters = Console.ReadLine();

for (int i = characters.Length - 1; i <= characters.Length; i--)
{
    Console.Write(characters[i]);
    if (i == 0)
    {
        break;
    }
}