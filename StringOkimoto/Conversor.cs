namespace ÈxercicioString
{
    public class Conversor
    {

        public int IntNumber { get; set; }
        public decimal DecimalNumber { get; set; }
        public double DoubleNumber { get; set; }
        public float FloatNumber { get; set; }
        public Conversor(int intNumber, decimal decimalNumber, double doubleNumber, float floatNumber)
        {
            IntNumber = intNumber;
            DecimalNumber = decimalNumber;
            DoubleNumber = doubleNumber;
            FloatNumber = floatNumber;
        }

        public void ConverterStringParaInt(string strNumber)
        {
            int result;
            if (int.TryParse(strNumber, out result))
            {
                IntNumber = result;
                Console.WriteLine(IntNumber);
            } else {
                Console.WriteLine("Não foi possível converter a string para int");
            }
        }

        public void ConverterStringParaDecimal(string strNumber)
        {
            decimal result;
            if (decimal.TryParse(strNumber, out result))
            {
                DecimalNumber = result;
                Console.WriteLine(DecimalNumber);
            } else {
                Console.WriteLine("Não foi possível converter a string para decimal");
            }
        }

        public void ConverterStringParaDouble(string strNumber)
        {
            double result;
            if (double.TryParse(strNumber, out result))
            {
                DoubleNumber = result;
                Console.WriteLine(DoubleNumber);
            } else {
                Console.WriteLine("Não foi possível converter a string para double");
            }
        }

        public void ConverterStringParaFloat(string strNumber)
        {
            float result;
            if (float.TryParse(strNumber, out result))
            {
                FloatNumber = result;
                Console.WriteLine(FloatNumber);
            } else {
                Console.WriteLine("Não foi possível converter a string para float");
            }
        }
    }
}
