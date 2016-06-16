using System;

namespace CalculatorModules
{
	class BeregnerClass 
	{
		// Foretager simple regneoperationer [+,-,*,/]
		public double Beregner (double num1, double num2, string operand) 
		{ 
			double answer = 0; 

			switch (operand) 
			{
				case "+":
					answer = num1 + num2;
					break; 

				case "-":
					answer = num1 - num2;
					break;

				case "*":
					answer = num1 * num2;
					break;

				case "/":
					answer = num1 / num2; 
					break;

					default: 
					answer = 0; 
					break; 
			}
			return answer; 
		}

	}

	class UdvidedeBeregningerClass : BeregnerClass
	{ 
		// Udvidelse af de regneoperationer der kan foretages af Beregner metoden
		public double Beregner2 (double num1, double num2, string operand) 
		{  
			double answer = 0; 

			if (operand == "+" || operand == "-" || operand == "*" || operand == "/") 
			{ 
				answer = Beregner (num1, num2, operand); 
				return answer; 
			} 
			else 
			{
				switch (operand) 
				{
				case "^": 
					answer = Math.Pow (num1, num2); 
						break;

					default: 
						answer = 0; 
						break; 
				} 
				return answer; 
			}
		} 
	}
}
	