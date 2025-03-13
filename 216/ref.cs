using System;
class demo
{
	public void fun (ref int p,ref int q)
	{
		Console.WriteLine("FUN 1 {0} {1}",p,q);
		p=5678;
		q=678;
		Console.WriteLine("FUN 1 {0} {1}",p,q);
	}
}
class main_cls
{
	public static void Main()
	{
		int b=43,c=67;
		demo x=new demo();
		x.fun(ref b,ref c);
		Console.WriteLine("before calling fun"+b+c);
		Console.WriteLine("after calling main b"+b);
		Console.WriteLine("after calling main c"+c);
	}
}