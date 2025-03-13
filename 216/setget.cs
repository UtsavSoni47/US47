using System;
class demo
{	
	private int a;
	public int pr_am
	{
		set
		{
			a=value;
		}
		get
		{
			return a;
		}
	}
}
class main_cls 
{
	public static void Main()
	{
		demo d=new demo();
		d.pr_am=10;
		Console.WriteLine("Value of A in main:"+d.pr_am);
	}
}