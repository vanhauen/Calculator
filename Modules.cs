using System;

namespace CalculatorModules
{
	class Calculator 
	{
		// Handles simple math operations with 2 arguments and a operator
		public double calculateResult (double argument_1, double argument_2, char input_operator) 
		{ 
			double result;
			switch (input_operator) 
			{
				case "+":
					answer = argument_1 + argument_2;
					break; 

				case "-":
					answer = argument_1 - argument_2;
					break;

				case "*":
					answer = argument_1 * argument_2;
					break;

				case "/":
					answer = argument_1 / argument_2; 
					break;

				default: 
					Console.WriteLine("Invalid operator; please try from the following [+,-,*,/]");
					break; 
			}

			return result; 
		}
	}

	class CalculatorExtension : Calculator
	{ 
		// Extension layer allowing for calculation of ^(power of)
		public double _calculateResult (double argument_1, double argument_2, char input_operator) 
		{  
			double result = 0; 

			//	In case of simple operator, call calculateResult()
			if (input_operator == "+" || input_operator == "-" || input_operator == "*" || input_operator == "/") 
			{ 
				result = calculateResult (argument_1, argument_2, input_operator); 
				return result; 
			} 
			else {
				switch (input_operator) {
					case "^": 
						result = Math.Pow (argument_1, argument_2); 
						break;

					default: 
						result = 0; 
						break; 
				} 

				return result; 
			}
		} 
	}
}