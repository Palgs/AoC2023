using System.Text.RegularExpressions;
using System.Threading.Tasks.Sources;

namespace AdventOfCode
{
	class Day1
	{
		static void Main(string[] args)
		{
			var input = File.ReadAllLines("Input.txt");

			Dictionary<int, string> numbersAsText = new Dictionary<int, string>()
			{
				{ 1, "one" },
				{ 2, "two" },
				{ 3, "three" },
				{ 4, "four" },
				{ 5, "five" },
				{ 6, "six" },
				{ 7, "seven" },
				{ 8, "eight" },
				{ 9, "nine" }
			};

			var res = 0;

			foreach (var line in input)
			{
				var nrs = new List<int>();
				foreach (var character in line)
				{
					if (numbersAsText.ContainsKey(Convert.ToInt32(character.ToString())))
					{
						nrs.Add(Convert.ToInt32(character.ToString()));
					}
					else
					{
						foreach (var value in numbersAsText)
						{
							if (value.Value.StartsWith(character))
							{

							}
						}
					}
				}
				var numbers = Regex.Matches(line, @"\d");

				var nr1 = "";
				var nr2 = "";
				if (!Regex.Match(numbers[0].Value, @"\d").Success)
				{
					nr1 = TextToNumber(numbers[0].Value);
				}
				else
				{
					nr1 = numbers[0].Value;
				}
				if (!Regex.Match(numbers[^1].Value, @"\d").Success)
				{
					nr2 = TextToNumber(numbers[^1].Value);
				}
				else
				{
					nr2 = numbers[^1].Value;
				}

				res += Convert.ToInt32(nr1 + nr2);
			}

			Console.WriteLine(res);
		}

		static string TextToNumber(string input)
		{
			switch (input)
			{
				case "one":
					return "1";
				case "two":
					return "2";
				case "three":
					return "3";
				case "four":
					return "4";
				case "five":
					return "5";
				case "six":
					return "6";
				case "seven":
					return "7";
				case "eight":
					return "8";
				case "nine":
					return "9";
				default:
					return "0";
			}
		}
	}
}