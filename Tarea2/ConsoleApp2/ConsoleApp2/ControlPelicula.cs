using AlmacenamientoPeliculas.peliculas;
namespace AlmacenamientoPeliculas.peliculas
{
    class ControlPelicula
    {
        private List <Pelicula> _peliculas;

        public ControlPelicula()
        {
            _peliculas = new List<Pelicula>();
        }

        public void showMenuPrincipal()
        {
            string? nombre;
            string? formato;
            string? genero;
            string? anio;
            string? productora;
            string? ubicacion;
            int opcionSeleccionada = 0;
            Console.Clear();
            do
            {
                Console.WriteLine("Bienvenido al sistema de control de películas.");
                Console.WriteLine("1.- Listar películas.");
                Console.WriteLine("2.- Agregar película.");
                Console.WriteLine("3.- Buscar película.");
                Console.WriteLine("4.- Eliminar película.");
                Console.WriteLine("5.- Salir.");
            } while (!validaMenu(5, ref opcionSeleccionada));
            switch (opcionSeleccionada)
            {

                case 1:
                    Console.Clear();
                    ListarPeliculas();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Alta de película.");
                    Console.WriteLine("\n");
                    do
                    {
                        Console.Write("Nombre de la película: ");
                        nombre = Console.ReadLine();
                        if(nombre == null ||nombre == "")
                        {
                            Console.WriteLine("Es un nombre inválido.");
                        }
                    } while (nombre == null || nombre == "");
                    do
                    {
                        Console.Write("Tipo de formato de la película: ");
                        formato = Console.ReadLine();
                        if (formato == null || formato == "")
                        {
                            Console.WriteLine("Es un nombre inválido.");
                        }
                    } while (formato == null || formato == "");
                    do
                    {
                        Console.Write("Género de la película: ");
                        genero = Console.ReadLine();
                        if (genero == null || genero == "")
                        {
                            Console.WriteLine("Es un nombre inválido.");
                        }
                    } while (genero == null || genero == "");
                    do
                    {
                        Console.Write("Año de la película: ");
                        anio = Console.ReadLine();
                        if (anio == null || anio == "")
                        {
                            Console.WriteLine("Es un nombre inválido.");
                        }
                    } while (anio == null || anio == "");
                    do
                    {
                        Console.Write("Nombre de la productora: ");
                        productora = Console.ReadLine();
                        if (productora == null || productora == "")
                        {
                            Console.WriteLine("Es un nombre inválido.");
                        }
                    } while (productora == null || productora == "");
                    do
                    {
                        Console.Write("Ubicacion de la película: ");
                        ubicacion = Console.ReadLine();
                        if (ubicacion == null || ubicacion == "")
                        {
                            Console.WriteLine("Es una ubicación inválida.");
                        }
                    } while (ubicacion == null || ubicacion == "");
                    Pelicula pelicula = new Pelicula(nombre, formato, genero, anio, productora, ubicacion);
                    _peliculas.Add(pelicula);
                    Console.WriteLine("Película agregada correctamente.");
                    Console.WriteLine("Presiona enter para continuar.");
                    Console.ReadLine();
                    showMenuPrincipal();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Buscar película.");
                    Console.WriteLine("\n");
                    nombre = null;
                    do
                    {
                        Console.WriteLine("Escriba el nombre de la película a buscar.");
                        nombre = Console.ReadLine();
                        if (nombre == null || nombre == "")
                        {
                            Console.WriteLine("Es un nombre inválido.");
                        }
                    } while (nombre == null || nombre == "");
                    Pelicula? peliBuscar = _peliculas.FirstOrDefault(p => p.nombre == nombre);
                    if(peliBuscar == null)
                    {
                        Console.WriteLine("Esta película no existe dentro de la colección. Presiona enter para continuar.");
                        Console.ReadLine();
                        showMenuPrincipal();
                    }
                    else
                    {
                        Console.WriteLine("" + peliBuscar.mostrarUbicacion());
                        Console.WriteLine("Presiona enter para continuar."); 
                        Console.ReadLine();
                        showMenuPrincipal();
                    }
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("Eliminar película.");
                    Console.WriteLine("\n");
                    nombre = null;
                    do
                    {
                        Console.WriteLine("Escriba el nombre de la película a eliminar.");
                        nombre = Console.ReadLine();
                        if (nombre == null || nombre == "")
                        {
                            Console.WriteLine("Es un nombre inválido.");
                        }
                    } while (nombre == null || nombre == "");
                    Pelicula? peliEliminacion = _peliculas.FirstOrDefault(p => p.nombre == nombre);
                    if (peliEliminacion == null)
                    {
                        Console.WriteLine("Esta película no existe dentro de la colección. Presiona enter para continuar.");
                        Console.ReadLine();
                        showMenuPrincipal();
                    }
                    else
                    {
                        _peliculas.Remove(peliEliminacion);
                        Console.WriteLine("La película " + nombre + " se eliminó correctamente. Presiona enter para continuar.");
                        Console.ReadLine();
                        showMenuPrincipal();
                    }
                        break;

                case 5:
                    Console.Clear();
                    break;
            }
        }

        private void ListarPeliculas()
        {
            Console.WriteLine("Lista de películas.");
            Console.WriteLine("\n");
            foreach (Pelicula item in _peliculas)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Presiona enter para continuar.");
            Console.ReadLine();
            showMenuPrincipal();
        }

        private bool validaMenu(int opciones, ref int opcionSeleccionada)
        {
            int n;
            if (int.TryParse(Console.ReadLine(), out n))
            {
                if (n <= opciones)
                {
                    opcionSeleccionada = n;
                    return true;
                }
                else
                {
                    Console.Clear ();
                    Console.WriteLine("Opción inválida");
                    return false;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("El valor ingresado no es válido");
                return false;
            }
        }
    }
}