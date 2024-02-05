namespace edu.PR.Ejercicio3._2901
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaActual = DateTime.Now;
            Console.WriteLine(fechaActual.ToString());
            DateTime fechaModificada;
           

            Random rd = new Random();

            int aniosAleatorio = rd.Next(0,5);
            fechaModificada = fechaActual.AddDays(1).AddMonths(-24).AddYears(aniosAleatorio);
            
            Console.WriteLine(fechaModificada.ToString());

            if(fechaActual>fechaModificada)
            {
                Console.WriteLine("El hoy es más grande");
            }
            else
            {
                Console.WriteLine("El hoy es más pequeño");
            }


        }
        
}
}