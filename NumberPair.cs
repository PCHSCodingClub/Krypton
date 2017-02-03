using System;
namespace Krypton
{
	public class NumberPair
	{
		int num1;
		int num2;

		public NumberPair(int a, int b)
		{
			this.num1 = a;
			this.num2 = b;
		}

		public int getStart(){
			return num1;
		}
		public int getEnd() {
			return num2;
		}
	}
}
