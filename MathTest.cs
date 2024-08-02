class Ma
{
	public void demo()
	{
		double theta = 0.0D;
		System.Console.WriteLine("sines of angles from 0 to 90 degrees");
		for(theta = 0.0; theta < = 90.00; theta + = 15)
		{
			double x = System.Math.Sin(theta * System.Math.PI/180);
			System.Console.WriteLine("sin" + theta);
			System.Console.WriteLine(" ={0:F4}" + x);
		}
	}
}

class MathTest
{
	public static void Main()
	{
		Ma ob=new Ma();
		ob.demo();
	}
}
 