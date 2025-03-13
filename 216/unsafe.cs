using System;
class main_cls 
{
	public static void Main()
	{
		unsafe
		{
			int *a;
			int b;
			a=&b;
			*a=89;
			Console.WriteLine(*a);
			Console.WriteLine(b);
		}
	}
}