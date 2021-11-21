using System;
using System.Text;

namespace CalculadoraFinDeAño
{
    public class Global
    {
        public static int dayCalculate { get; set; }
        public static int dayResult { get; set; }
        public static int MounthCalculate { get; set; }

    }

    class Temp
    {

        public int num = 2;

        public Temp() { num++; }

        ~Temp() { num++; }

    }


    class Program
    {
        static void Print<x>(x Y)
        {

            Console.WriteLine(Y);
        }

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
            if (result == true)
            {
                Global.MounthCalculate = 12 - mounth;
                Global.dayCalculate = 31 - day;
                Console.WriteLine($"Faltan {Global.MounthCalculate} Meses y {Global.dayCalculate} Dias para Acabarse el 2021 ");                    
            }
            Console.WriteLine("La fecha Actual es: {0} ", date);
        }


        /// <summary>
        /// Función para Validar 
        /// </summary>
        /// <param name="day"></param>
        /// <param name="mounth"></param>
        /// <returns></returns>
        private static bool Validation(int day, int mounth)
        {
            StringBuilder errors = new StringBuilder();
            switch (mounth)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (day > 31 || day <= 0)
                    {
                        errors.AppendLine("El día " + day + " digitado es incorrecto para el mes de " + (Mes)mounth);
                        errors.AppendLine("Por favor Digita el día Correctamente!");
                        Console.WriteLine(errors.ToString());
                        return false;
                    }
                    break;
                case 2:
                    if (day > 28 || day <= 0)
                    {
                        errors.AppendLine("El día " + day + " digitado es incorrecto para el mes de " + (Mes)mounth);
                        errors.AppendLine("Por favor Digita el día Correctamente!");
                        Console.WriteLine(errors.ToString());
                        return false;
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (day > 30 || day <= 0)
                    {
                        errors.AppendLine("El día " + day + " digitado es incorrecto para el mes de " + (Mes)mounth);
                        errors.AppendLine("Por favor Digita el día Correctamente!");
                        Console.WriteLine(errors.ToString());
                        return false;
                    }
                    break;

                default:
                    Console.WriteLine("El mes digitado No existe, Por favor Digita el Mes Correctamente!");
                    return false;

            }
            return true;
        }
    }
    /// <summary>
    /// Enumeración para Imprimir el Mes Seleccionado
    /// </summary>
    public enum Mes
    {
        Enero = 1,
        Febrero = 2,
        Marzo = 3,
        Abril = 4,
        Mayo = 5,
        Junio = 6,
        Julio = 7,
        Agosto = 8,
        Septiembre = 9,
        Octubre = 10,
        Noviembre = 11,
        Diciembre = 12
    }

    /// <summary>
    /// Enumeración para Imprimir el Mes Seleccionado
    /// </summary>
       public enum Dias : ushort
    {
        Enero = 31,
        Febrero = 28,
        Marzo = 31,
        Abril = 30,
        Mayo = 31,
        Junio = 30,
        Julio = 31,
        Agosto = 31,
        Septiembre = 30,
        Octubre = 31,
        Noviembre = 30,
        Diciembre = 31
    }


}


