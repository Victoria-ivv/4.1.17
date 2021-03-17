using System;

class MainClass
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

		//var color = Console.ReadLine();
		
		for (int i=5; i >0; i--)
		{
			Console.WriteLine("Iteration{0}", i);
			switch (Console.ReadLine())
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
					Console.BackgroundColor = ConsoleColor.Cyan;
					Console.ForegroundColor = ConsoleColor.Black;

					Console.WriteLine("Your color is cyan!");
					break;

				default://если другой цвет
					Console.BackgroundColor = ConsoleColor.Yellow;
					Console.ForegroundColor = ConsoleColor.Red;

					Console.WriteLine("Your color is yellow!");
					break;
			}
			
		}
		
	}
}