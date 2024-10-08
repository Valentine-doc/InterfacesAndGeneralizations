class Program
{
    static void Main()
    {
        ForExampleMyBits bits1 = new ForExampleMyBits(34144522545L); // long
        ForExampleMyBits bits2 = new ForExampleMyBits(-1025); // int
        ForExampleMyBits bits3 = new ForExampleMyBits(9); // byte

        Console.WriteLine("\n"+bits1.ToString());
        Console.WriteLine("byte: " + bits1.AsByte());
        Console.WriteLine("int: " + bits1.AsInt());
        Console.WriteLine("long: " + bits1.AsLong()+ "\n");

        Console.WriteLine(bits2.ToString());
        Console.WriteLine("byte: " + bits2.AsByte());
        Console.WriteLine("int: " + bits2.AsInt());
        Console.WriteLine("long: " + bits2.AsLong()+"\n");

        Console.WriteLine(bits3.ToString());
        Console.WriteLine("byte: " + bits3.AsByte());
        Console.WriteLine("int: " + bits3.AsInt());
        Console.WriteLine("long: " + bits3.AsLong()+"\n");
    }
}
