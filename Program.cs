Console.WriteLine("Enter number of columns");
try
{
    int colums = int.Parse(Console.ReadLine());
    int rows = colums*2-1;
    int center = colums;
    for (int i = 1; i <= rows; i++)
	{
        if (i<=center)
        {
            for (int j = 1; j <=i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
        else
        {
            for (int j = 1; j <= i-(i-center)*2; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
	}
}
catch (Exception)
{
    Console.WriteLine("Enter only numbers!!!");
}
