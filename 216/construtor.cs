using System;
class xyz
{
	public int x;
	public xyz()  {}
	public xyz(xyz cpy)
	{
		x=cpy.x;
		Console.WriteLine("constructor");
	}
	public static void Main()
	{
		xyz obj1=new xyz();
		obj1.x=Convert.ToInt32(Console.ReadLine());
		xyz obj2=new xyz(obj1);
		Console.WriteLine("data of obj1.x"+obj1.x);
		Console.WriteLine("data of obj2.x"+obj2.x);
		Console.WriteLine();
	
	}
}	
		