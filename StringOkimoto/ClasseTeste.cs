namespace ÈxercicioString
{
    public class ClasseTeste
    {
        public string str { get; set; }
        public string str2 { get; set; }
        public string str3 { get; set; }

        public ClasseTeste() {
            this.str = "ABCTPX";
            this.str2 = "QWERTY";
            this.str3 = "ASDFGH";
        }

        public ClasseTeste(string str, string str2, string str3)
        {
            this.str = str;
            this.str2 = str2;
            this.str3 = str3;
        }

        public void PrintarEnum (EnumTeste enumTeste)
        {
            switch (enumTeste)
            {
                case EnumTeste.PrimeiraStr:
                    Console.WriteLine(str);
                    break;
                case EnumTeste.SegundaStr:
                    Console.WriteLine(str2);
                    break;
                case EnumTeste.TerceiraStr:
                    Console.WriteLine(str3);
                    break;
                default:                    
                    Console.WriteLine("Enum não encontrado");
                    break;
            }
        }
    }

}
