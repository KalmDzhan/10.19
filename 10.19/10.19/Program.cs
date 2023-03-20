int count = 0;

Console.Write("Введите 3 предложения: ");
string text = Console.ReadLine().ToLower();

Console.Write("Введите букву, количество которой надо подсчитать: ");
char letter = Convert.ToChar(Console.ReadLine());

foreach (char symbol in text)
{
	if (symbol == letter)
	{
		count++;
	}
}
Console.WriteLine("В вашем тексте " + count + " букв " + letter);