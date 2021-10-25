using System;

namespace CalculadoraFinDeAño
{
    public class Global
    {
        public static int dayCalculate { get; set; }
        public static int dayResult { get; set; }
        public static int MounthCalculate { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora para Saber Cuantos Dias Faltan Para Acabarse el año 2021: ");
            Console.WriteLine("Dia: ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mes: ");
            int mounth = Convert.ToInt32(Console.ReadLine());
            DateTime dt = DateTime.Now;
            String date;
            date = dt.ToString("f");
            bool result = Validation(day, mounth);
            if (result == false)
            {
               
       
            }

            






            //Operacion 
            switch (mounth)

            {
                case 1:
                    Global.dayCalculate = 31 - day;
                    Global.MounthCalculate = 12 - mounth;
                    Global.dayResult = 365 - Global.dayCalculate;                    
                    Console.WriteLine("Faltan {0} Meses y {0} Dias para Acabarse el 2021 ", Global.MounthCalculate, Global.dayResult);
                    Console.WriteLine("La fecha Actual es: {0} ", date);

                    break;
            }
            
        }
     
        private static bool Validation(int day, int mounth)
        {
            String errors = string.Empty;
            if (day > 31 || day <= 0  )
            {
                errors = "Hay un error en el Dia:";
                Console.WriteLine(errors);
                return false;
            }
            if (mounth > 12 || day <= 0)
            {
                return false;
            }

            return true;
        }


    }
}
