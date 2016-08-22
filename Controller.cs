using System;
using Calculation;
using InputHandling;

namespace Controller
{
	class Controller
	{
		public static void Main (string[] args)
		{
			double argument_1 = 0; 
			double argument_2 = 0;
			double result     = 0;
			bool   run        = true;  
			string input_operator;

			//	Initialize Classes
			Calculator calculator = new Calculator();
			Input      input      = new Input();

			// Read first number
				Console.WriteLine ("Write your first argument");
				argument_1 = input.readNumber();
			
			//	Initiate run-cycle
			do {
				// Read operator
				Console.WriteLine ("Choose an operator [+, -, *, /, ^]");
				input_operator = input.readOperator();

				// Read second number
				Console.WriteLine ("\bWrite your second argument");
				argument_2 = input.readNumber();
						
				// Calculation result based on user input
				result = calculator.calculateResult(argument_1, argument_2, input_operator); 
						
				//	Print result and await further calculations
				Console.WriteLine(result); 
				argument_1 = result; 
				
			}
			while (run);
		}
	}
}