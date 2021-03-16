using System;

class MainClass
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

		var color = Console.ReadLine();

		switch (color)
		{
			case "red": //если выберем красный
				Console.BackgroundColor = ConsoleColor.Red;
				Console.ForegroundColor = ConsoleColor.Black;

				Console.WriteLine("Your color is red!");
				break;

			case "green": //если выберем зеленый
				Console.BackgroundColor = ConsoleColor.Green;
				Console.ForegroundColor = ConsoleColor.Black;

				Console.WriteLine("Your color is green!");
				break;

			case "cyan": //если выберем голубой
			case "cyan":
				Console.BackgroundColor = ConsoleColor.Cyan;
				Console.ForegroundColor = ConsoleColor.Black;

				Console.WriteLine("Your color is cyan!");
				break;
		}
	}
}