using System;
using CalculatorModules; 


namespace Calculator0
{
	class MainClass
	{  

		public static void Main (string[] args)
		{
			//Deklaration af variabler
			double num1 = 0; 
			double num2 = 0;
			double answer = 0;
			string operand;
			bool continue2 = true; 

			//Deklaration af klasse [Valg af regneoperation]
			UdvidedeBeregningerClass udregn = new UdvidedeBeregningerClass ();

			// Få input fra bruger. Do while løkken sikre at bruger kan regne videre på sidste resultat samt 
			//Afslutning af programmet ved at indtaste "q"

				Console.WriteLine ("Indtast dit første tal");
				num1 = Convert.ToDouble(Console.ReadLine ());

			do 
				{
				
				Console.WriteLine ("Indtast din operator [+, -, *, /, ^]");
				operand = Console.ReadLine();

				if(operand == "q")
					{
						continue2 = false; 
					} 
				else 
					{
						Console.WriteLine ("Indtast dit andet tal");
						num2 = Convert.ToDouble(Console.ReadLine ());
						
						// Kald af klasse som kalder den klasse der indeholde den pågældende regneoperation
						answer = udregn.Beregner2(num1, num2, operand); 
						
						//Print af resulatat og videreførsel af resultat til næste cyklus.
						Console.WriteLine(answer); 
						num1 = answer; 
					}
				}
			while (continue2);
		}
	}
}
