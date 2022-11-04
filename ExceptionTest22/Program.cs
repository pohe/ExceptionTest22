// See https://aka.ms/new-console-template for more information
using ExceptionTest22;

Console.WriteLine("Hello, World!");

try
{
    Console.WriteLine("Indtast tal 1 i intervallet fra 0 til 100");
    int tal1 = int.Parse(Console.ReadLine());
    if (tal1 >100 || tal1 < 0)
    {
        throw new NotInRangeException("Tallet skal vøre i intervallet fra 0 til 100");
    }

    Console.WriteLine("Indtast tal 2");
    int tal2 = int.Parse(Console.ReadLine());

    int result = tal1 / tal2;

    Console.WriteLine($"Resultatet af {tal1} divideret med {tal2} er {result}");

}
catch (FormatException fex)
{
    Console.WriteLine("Indtast venligst et helt tal " + fex.Message);
}
catch (DivideByZeroException dex)
{
    Console.WriteLine("Error der er division med 0 " + dex.Message);
}
catch(OverflowException oex)
{
    Console.WriteLine("Tallet var for stort " + oex.Message );
}
catch(NotInRangeException nex)
{
    Console.WriteLine(nex.Message);
}
catch(Exception ex)
{
    Console.WriteLine("Der forekom en generel exception");
}
finally
{
    Console.WriteLine("Denne del bliver altid udført.");
}




