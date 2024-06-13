namespace TypeConversion;

public class Bits
    {
    public long value { get; private set; } = 0;

    public Bits(long num)
        {
        this.value = num;
        }

    public static explicit operator long(Bits num) => (long)num.value;
    public static implicit operator Bits(long num) => new Bits(num);
    public static explicit operator int(Bits num) => (int)num.value;
    public static implicit operator Bits(int b) => new Bits(b);

    public static explicit operator byte(Bits num) => (byte)num.value;
    public static implicit operator Bits(byte num) => new Bits(num);
    }
