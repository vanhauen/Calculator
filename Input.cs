using System;

namespace InputHandling
{
    class Input
    {
        private string readLine(){
            string line = Console.ReadLine();
            return line;
        }

        private string readKey(){
            string key = Console.ReadKey().Key.ToString();
            return key;
        }

        public double readNumber(){
            double number = Convert.ToDouble(this.readLine());
            return number;
        }

        public string readOperator(){
            string input = this.readKey();
            
            switch(input){
                case "OemPlus":
					return "addition";
				case "OemMinus":
					return "subtraction";
				case "Oem2":
					return "multiply";
				case "D7":
					return "divide";
				case "Oem1":
					return "powerOf";
                default:
                    Console.WriteLine("Try again, operator?");
                    return this.readOperator();
            }
        }
    }

}