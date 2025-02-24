class abc
{
	public static void main(String[] args)
	{
		System.out.println(add(5,10));
		System.out.println(add(5.5,10.3));
		System.out.println(add(5,10,15));
		
	}
	public static int add(int a,int b)
	{
		return a+b;
	}
	public static int add(int a,int b,int c)
	{
		return a+b+c;
	}
	public static double add(double a,double b)
	{
		return a+b;
	}
}