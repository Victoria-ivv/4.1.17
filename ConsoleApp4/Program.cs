using System;

class MainClass
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Цикл while");
		int k = 0; //для цикла while k
		//Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
		//var color = Console.ReadLine();
		//for (int i=5; i >0; i-- ) //обратный цикл for
		//for (int i=5; i >0; ) //бесконечный цикл for
		//while (true) //бесконечный цикл while
		//do // do while
		while (k<3)//для цикла while k
		{
			Console.WriteLine(k);
			Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
			//Console.WriteLine("Iteration{0}", i); //для цикла for
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
			k++; //для цикла while k
		} //while (true); // do while 

	}
}