 static double Sqrt(double value)
{
    if(value < 0)
    {
        throw new ArgumentOutOfRangeException("Invalid Input.");
    }
    return Math.Sqrt(value);
}
int number = int.Parse(Console.ReadLine());
try
{
  double root = Sqrt(number);
    Console.WriteLine(root);

}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine("Invalid number.");
}
finally
{
    Console.WriteLine("Goodbye.");
}