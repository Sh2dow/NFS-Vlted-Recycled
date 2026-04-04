namespace VaultEditor;

internal readonly struct Struct6
{
    private readonly byte[] byte_0;

    private readonly int int_0;

    private readonly bool bool_0;

    public int Int32_0 => int_0;

    public bool this[int int_1]
    {
        get
        {
            if (byte_0 == null)
            {
                return bool_0;
            }
            byte num = byte_0[int_1 >> 3];
            int num2 = 128 >> (int_1 & 7);
            return (num & num2) != 0;
        }
    }

    public Struct6(int int_1, bool bool_1)
    {
        byte_0 = null;
        int_0 = int_1;
        bool_0 = bool_1;
    }

    public Struct6(int int_1, byte[] byte_1)
    {
        byte_0 = byte_1;
        int_0 = int_1;
        bool_0 = false;
    }

    public int method_0()
    {
        if (byte_0 == null)
        {
            if (!bool_0)
            {
                return 0;
            }
            return int_0;
        }
        int num = 0;
        for (int i = 0; i < int_0; i++)
        {
            if (this[i])
            {
                num++;
            }
        }
        return num;
    }
}
