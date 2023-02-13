//По двум заданным числам проверять является ли первое квадратом второго
Console.WriteLine("Enter first number: ");
	int a = int.Parse(Console.ReadLine()!);
	Console.WriteLine("Enter second number: ");
	int b = int.Parse(Console.ReadLine()!);
	int sum=a*a;
	if (sum==b)
	{
    	Console.WriteLine("Является:"+sum);
    
	} 
	else if (sum>b){

    	Console.WriteLine("Не является квадратом:"+sum);
	} 
	else if (sum<b) {

    	Console.WriteLine("Не является квадратом:"+sum);
	} 
