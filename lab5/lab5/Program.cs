using System;

namespace lab5_1
{
	class Program
	{
		static void Main(string[] args)
		{
			A A = new A();
			Console.Write("Result = ");
			Console.WriteLine(A.C(1, 2));
		}
	}

	class A
	{
		private int a;
		private int b;

		public int C(int n, int m)
		{
			this.a = n;
			this.b = m;
			return n + m;
		}
	}
}