namespace Specflow
{
    public static class Calculator
    {
        public static double Value1 { get; set; }
        public static double Value2 { get; set; }


        public static double Plus()
        {
            return Value1 + Value2;
        }

        public static double Minus()
        {
            return Value1 - Value2;
        }
        public static double Multiply()
        {
            return Value1 * Value2;
        }
        public static double Devide()
        {
            return Value1 / Value2;
        }
    }
}
