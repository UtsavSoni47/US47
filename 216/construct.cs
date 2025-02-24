using System;
class xyz
{
	int a;
	void fun() 
	{
		Console.WriteLine(a);
	}
	public static void Main()
	{
		xyz obj1=new xyz();
		xyz obj2=new xyz();
		obj1.a=119;
		obj1.fun();
		obj2.a=220;
		obj2.fun();
		Console.WriteLine("SYB");
		Console.ReadLine();
	}
}
		
