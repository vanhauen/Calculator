using System;
using System.Reflection;

namespace Calculation
{
	class Calculator
	{
		private double result;
		private double argument_1;
		private double argument_2;

		public double calculateResult(double argument_1, double argument_2, string input_operator){		
			this.argument_1 = argument_1;
			this.argument_2 = argument_2;

			MethodInfo theMethod = this.GetType().GetMethod(input_operator);
			theMethod.Invoke(this, null);

			return result;
		}

		public void addition(){
			this.result = this.argument_1 + this.argument_2;
		}
		public void subtraction(){
			this.result = this.argument_1 - this.argument_2;
		}
		public void multiply(){
			this.result = this.argument_1 * this.argument_2;
		}
		public void divide(){
			this.result = this.argument_1 / this.argument_2;
		}
		public void powerOf(){
			this.result = Math.Pow (this.argument_1, this.argument_2); 		
		}
	}
}
