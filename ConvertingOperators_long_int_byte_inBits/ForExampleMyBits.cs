public class ForExampleMyBits : ISupposeMyBits
{
    private long value;

    public ForExampleMyBits(long value)
    {
        this.value = value;
        Console.WriteLine($"ForExampleMyBits: {value}");
    }

    public override string ToString()
    {
        return $"ForExampleMyBits: {value}";
    }

    public byte AsByte()
    {
        if (value > byte.MaxValue || value < byte.MinValue)
        {
            Console.WriteLine("Значение не может быть преобразовано в byte");
            return 0; 
        }
        return (byte)value;
    }

    public int AsInt()
    {
        if (value > int.MaxValue || value < int.MinValue)
        {
            Console.WriteLine("Значение не может быть преобразовано в int");
            return 0; 
        }
        return (int)value;
    }

    public long AsLong()
    {
        return value;
    }
}

