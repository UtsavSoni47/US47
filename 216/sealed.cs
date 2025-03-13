using System;
class demo
{
	public void fun()
	{
		Console.WriteLine("FUN");
	}

}
sealed class xyz:demo
{
	public void method()
	{
		Console.WriteLine("method");
	}
}
class main_cls
{
	public static void Main()
	{
		xyz x=new xyz();
		x.fun();
		x.method();
		Console.WriteLine("MAIN");
		}
}