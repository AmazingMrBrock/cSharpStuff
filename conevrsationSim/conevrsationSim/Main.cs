using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace conevrsationSim

{
	class MainClass
	{
		//Variables
		public static string inputString;

		//Lists and Dictionarys
		public static List<string> wordList = inputString.Split(' ').ToList();
		public static List<string> dicList = new List<string>();
		public static List<string> keyList = new List<string>();

		public static Dictionary<string, string> keyLookup = new Dictionary<string, string>();
		public static Dictionary<string, string> mathFunction = new Dictionary<string, string>();
		public static Dictionary<string, int> dictionary = new Dictionary<string, int>();

		public static void Main (string[] args)
		{
			while (true) 
			{
				StartScript ();
				WordChecker ();
				WordMeaning ();
			}
		}

		public static void StartScript()
		{

			if (inputString == null)
			Console.WriteLine ("Enter Input");
			inputString = Console.ReadLine ();

		}

		public static void WordChecker()
		{
			inputString = Console.ReadLine ();
			inputString = inputString.ToLower();  

			string[] stripChars = { ";", ",", ".", "-", "_", "^", "(", ")", "[", "]",
				"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "\n", "\t", "\r" };
			foreach (string character in stripChars)
			{
				inputString = inputString.Replace(character, "");
			}


			// Define and remove stopwords
			string[] stopwords = new string[] { "and", "the", "she", "for", "this", "you", "but" };
			foreach (string word in stopwords)
			{
				while ( wordList.Contains(word) )
				{
					wordList.Remove(word);
				}
			}
		

			foreach (string word in wordList)
			{
				// If the length of the word is at least three letters...
				if (word.Length >= 3) 
				{
					// ...check if the dictionary already has the word.
					if ( dictionary.ContainsKey(word) )
					{
						// If we already have the word in the dictionary, increment the count of how many times it appears
						dictionary[word]++;
					}
					else
					{
						// Otherwise, if it's a new word then add it to the dictionary with an initial count of 1
						dictionary[word] = 1;
					}

				}
			}

		}


		public static void WordMeaning()
		{
			dicList = dictionary.Keys.ToList ();

			keyLookup["hey"] = "greeting";
			keyLookup["hi"] = "greeting";
			keyLookup["greeting"] = "greeting";
			keyLookup["math"] = "math";
			keyLookup["calculate"] = "math";
			keyLookup["equation"] = "math";

			string foundKey = keyLookup[word];

			foreach (string mKey in keyList)
				{
					if(mKey == "greeting")
					{Greetings ();}
					if (mKey == "math") 
					{Math ();}
				}
		}

		public static void Math()
		{
			Console.WriteLine ("What do you want me to math?");
			Console.WriteLine ("input a number");
			string input = Console.ReadLine ();
			decimal a = Convert.ToDecimal (input);
			Console.WriteLine("Tell me math function");
			string mFunction = Console.ReadLine();
			Console.WriteLine ("tell me another number");
			string inputB = Console.ReadLine();
			decimal b = Convert.ToDecimal (inputB);

			mathFunction["multiply"] = "multiply";
			mathFunction["times"] = "multiply";
			mathFunction["x"] = "multiply";
			mathFunction["*"] = "multiply";
			mathFunction["divide"] = "divide";
			mathFunction["/"] = "divide";
			mathFunction["subtract"] = "subtract";
			mathFunction["minus"] = "subtract";
			mathFunction["-"] = "subtract";
			mathFunction["add"] = "add";
			mathFunction["+"] = "add";
			mathFunction["plus"] = "add";

			string foundKey = mathFunction[mFunction];

			if (foundKey == "add")
			{
				Console.WriteLine (a + b);
			}
			else if (foundKey == "subtract")
			{
				Console.WriteLine (a - b);
			}
			else if (foundKey == "multiply")
			{
				Console.WriteLine (a * b);
			}
			else if (foundKey == "divide")
			{
				Console.WriteLine (a / b);
			}
			else
			{
				Console.WriteLine ("not a math");
			}

		}

		public static void Greetings()
		{
			Console.WriteLine("You said hello");
			
		}
	}
}
