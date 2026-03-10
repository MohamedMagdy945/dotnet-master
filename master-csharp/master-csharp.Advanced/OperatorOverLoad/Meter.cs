


using master_csharp.Advanced.OperatorOverLoad;

namespace master_csharp.Advanced.OperatorOverLoad
{
    class CM
    {
        public double Value;

    }
    class Meter
    {
        public double Value;

        public Meter(double value)
        {
            Value = value;
        }

        public static implicit operator Meter(double value)
        {
            return new Meter(value);
        }
        public static implicit operator double(Meter value)
        {
            return value.Value;
        }
        public static explicit operator CM(Meter meter)
        {
            return new CM() { Value = meter.Value*100};
        }
    }
}
class CastingOperatorOverload()
{
    public static void Use()
    {
        Meter m = new Meter(4);

        m = 8;

        CM cm = (CM)m;
        Console.WriteLine(cm.Value); // 800
    }
}
