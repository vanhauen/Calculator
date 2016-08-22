using System;
using Calculation;
//using CalculatorModules; 

namespace Controller
{
	class Controller
	{
		public static void Main (string[] args)
		{
			double argument_1 = 0; 
			double argument_2 = 0;
			double result     = 0;
			bool   cont       = true;  
			string input_operator;

			//	Initialize Calculation Class
			//  CalculatorExtension calculator = new CalculatorExtension ();
			Calculator calculator = new Calculator();

			//	Reading user input
			//	Terminate application by pressing "q"

			Console.WriteLine ("Write your first argument");
			argument_1 = Convert.ToDouble(Console.ReadLine ());

			do {
				Console.WriteLine ("Choose an operator [+, -, *, /, ^]");
				input_operator = Console.ReadKey().Key.ToString();
				Console.WriteLine ("\b");

				if(input_operator == "q"){
					cont = false; 
				} 
				else {
					Console.WriteLine ("Write your second argument");
					argument_2 = Convert.ToDouble(Console.ReadLine ());
						
					// Calculation result based on user input
					result = calculator.calculateResult(argument_1, argument_2, input_operator); 
						
					//	Print result and await further calculations
					Console.WriteLine(result); 
					argument_1 = result; 
				}
			}
			while (cont);
		}
	}
}