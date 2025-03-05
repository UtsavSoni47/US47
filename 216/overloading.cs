using System;
class person
{
	public void display()
	{
		Console.WriteLine("1st calling");
	}
	public void display(int a,double b)
	{
		Console.WriteLine("3rd calling"+a+b);
	}
	/*public void display(double b,int a)
	{
		Console.WriteLine("2nd calling");
	}*/
}
class demo
{
	public static void Main()
	{
		Console.WriteLine("hii");
		person v1=new person() ;
		v1.display();
		v1.display(10,11.50);
		//v1.display(11.50,10);
		Console.WriteLine("hello");
		
	}
}
