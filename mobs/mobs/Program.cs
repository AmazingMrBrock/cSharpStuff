using System;

namespace mobs
{
	class MainClass
	{
		//Initialize
		static Random _r =new Random();

		//Variables

		static int maxDice;
		static int diceType;
		static string input;
		static string inputB;
		
		public static void Main (string[] args)
		{
			while (true) 
			{
				Dice();
			}
		}

		public static void Dice()
		{
			input = Console.ReadLine();
			input = input.ToLower();
			inputB = input;


			if (input.Contains("d"))
			{
				DiceChecker();
				DiceLoop();
			}

		}

		public static int RandomDice()
		{
			int n = _r.Next (1, diceType);
			return n;
		}

		public static void DiceLoop()
		{
			int result = 0;
			for(int i = 0; i < maxDice; i++)
			{
				result += RandomDice();
			}
			Console.WriteLine(result);
		}

		public static void DiceChecker()
		{
			string output = inputB.Substring(inputB.IndexOf('d') + 1);
			int index = input.IndexOf("d");
			if (index > 0)
				input = input.Substring(0, index);

			string[] stripChars = {"d"};
			foreach (string character in stripChars)
			{
				inputB = inputB.Replace(character, "");
				input = input.Replace(character, "");
			}
			maxDice = Convert.ToInt32(input);
			diceType = Convert.ToInt32(output);
		}
	}
}
