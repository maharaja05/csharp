class Incre
{
	public void demo(int m,int n)	
	{
		System.Console.WriteLine(" m = "+ m); 
		System.Console.WriteLine(" n = "+ n);
		System.Console.WriteLine(" ++m = "+ ++m); 
		System.Console.WriteLine(" n++ ="+ n++); 
		System.Console.WriteLine(" m = "+ m); 
		System.Console.WriteLine(" n = "+ n);	
	}
}

class IncrementOperator
{
	public static void Main()
	{
		int m = 10, n = 20; 
		Incre obj= new Incre();
		obj.demo(m,n);
		
	}
}