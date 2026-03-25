namespace Project
{
    public class Calculator
    {
        public int Add_int(int a, int b)
        {
            return a + b;
        }
        public int Subtract_int(int a, int b)
        {
            return a - b;
        }
        public int Multiply_int(int a, int b)
        {
            return a * b;
        }
        public Double Divide_int(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return (double)a / b;
        }
    }
}
