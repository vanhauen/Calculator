using System;

namespace Calculation
{
	class Calculator
	{
		public double calculateResult(double argument_1, double argument_2, string input_operator){
			
			/*DEBUG: Output given input to console*/
			//Console.WriteLine("TICK: " + input_operator);
			
			switch (input_operator) {
				case "OemPlus":
					return addition(argument_1, argument_2);
				case "OemMinus":
					return subtraction(argument_1, argument_2);
				case "Oem2":
					return multiply(argument_1, argument_2);
				case "D7":
					return divide(argument_1, argument_2);
				case "Oem1":
					return powerOf(argument_1, argument_2);
				default: 
					Console.WriteLine("Invalid operator; please try from the following [+,-,*,/]");
					return 0.0; 
			}
		}

		private double addition(double argument_1, double argument_2){
			return argument_1 + argument_2;
		}
		private double subtraction(double argument_1, double argument_2){
			return argument_1 - argument_2;
		}
		private double multiply(double argument_1, double argument_2){
			return argument_1 * argument_2;
		}
		private double divide(double argument_1, double argument_2){
			return argument_1 / argument_2;
		}
		private double powerOf(double argument_1, double argument_2){
			return Math.Pow (argument_1, argument_2); 		
		}
	}
}
