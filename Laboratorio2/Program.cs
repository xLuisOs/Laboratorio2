class program
{
    static void Main(string[]args)
    {
        bool salir = false;
        while (salir)
        {
            Console.Clear();
            Console.WriteLine("MENU");
            Console.WriteLine("1. Agregar habitacion ");
            Console.WriteLine("2. Eliminar habitacion ");
            Console.WriteLine("3. Mostrar habitaciones ");
            Console.WriteLine("4. Asignar habitacion al cliente");
            Console.WriteLine("5. Liberar habitacion ");
            Console.WriteLine("6. Salir");
            string opcion = Console.ReadLine();

            try
            {

            }
            catch
            {

            }
            if (!salir)
            {
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}