using System;
using System.Text;

namespace CalculadoraFinDeAño
{

    #region Variables
    /// <summary>
    /// Variables
    /// </summary>
    public class Global
    {
        public static int dayCalculate { get; set; }
        public static int dayResult { get; set; }
        public static int MounthCalculate { get; set; }
        public static int currentlyYear { get; set; }
        public static string date { get; set; }
        public static int day { get; set; }
        public static int mounth { get; set; }

    }
    #endregion

    #region Main
    /// <summary>
    /// Main
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            localTimeConfigure();
            Console.WriteLine($"Calculadora para Saber Cuantos Dias Faltan Para Acabarse el año {Global.currentlyYear}: ");
            Console.WriteLine("Dia: ");

            bool validateDay = ValidationDay(Console.ReadLine());
            if (validateDay == false) { Environment.Exit(0); }

            Console.WriteLine("Mes: ");
            bool validateMounth = ValidationMounth(Console.ReadLine());
            if (validateMounth == false) { Environment.Exit(0); }

            bool result = Validation(Global.day, Global.mounth);
            if (result == true)
            {
                Global.MounthCalculate = 12 - Global.mounth;
                Global.dayCalculate = 31 - Global.day;
                Console.WriteLine("Faltan {0} Meses y {1} Dias para Acabarse el año {2} ", Global.MounthCalculate, Global.dayCalculate, Global.currentlyYear);
            }
            Console.WriteLine("La fecha actual es: {0} ", Global.date);

        }
        #endregion

    #region Functions

        /// <summary>
        /// valido que el mes se un un integer
        /// </summary>
        /// <param name="mounth"></param>
        /// <returns></returns>
        private static bool ValidationMounth(String mounth)
        {
            try
            {
                int result = Int32.Parse(mounth);
                Global.mounth = result;
                return true;
            }
            catch (FormatException)
            {
                Console.WriteLine($"Esto '{mounth}' no es una entrada valida para mes. Por favor ingrese un mes valido.");
                return false;
            }

        }

        /// <summary>
        /// valido que el dia se un un integer
        /// </summary>
        /// <param name="day"></param>
        /// <returns></returns>
        private static bool ValidationDay(String day)
        {
            try
            {
                int result = Int32.Parse(day);
                Global.day = result;
                return true;
            }
            catch (FormatException)
            {
                Console.WriteLine($"Esto '{day}' no es una entrada valida para dia. Por favor ingrese un dia valido.");
                return false;
            }

        }

        /// <summary>
        /// Función para establecer variables de Fecha
        /// </summary>
        private static void localTimeConfigure()
        {
            DateTime dt = DateTime.Now;
            Global.currentlyYear = dt.Year;
            Global.date = dt.ToString("f");
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
    #endregion

    #region Enumerations
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
#endregion




