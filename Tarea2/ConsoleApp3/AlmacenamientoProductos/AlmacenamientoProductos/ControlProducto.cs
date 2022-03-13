using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenamientoProductos
{
    class ControlProducto
    {
        private List<Producto> _productos;

        public ControlProducto()
        {
            _productos = new List<Producto>();
        }
        public void showMenuPrincipal()
        {
            int? id;
            string? nombre;
            string? categoria;
            double? precio;
            int? ranking;
            int opcionSeleccionada = 0;
            Console.Clear();
            do
            {
                Console.WriteLine("Bienvenido al sistema de control de productos.");
                Console.WriteLine("1.- Listar productos.");
                Console.WriteLine("2.- Agregar producto.");
                Console.WriteLine("3.- Ranking producto.");
                Console.WriteLine("4.- Eliminar producto.");
                Console.WriteLine("5.- Salir.");
            } while (!validaMenu(5, ref opcionSeleccionada));
            switch (opcionSeleccionada)
            {

                case 1:
                    Console.Clear();
                    ListarProductos();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Alta de producto.");
                    Console.WriteLine("\n");
                    do
                    {
                        Console.Write("id del producto: ");
                        id = int.Parse(Console.ReadLine());
                        if (id == null)
                        {
                            Console.WriteLine("Es un id inválido.");
                        }
                    } while (id == null);
                    do
                    {
                        Console.Write("Nombre del producto: ");
                        nombre = Console.ReadLine();
                        if (nombre == null || nombre == "")
                        {
                            Console.WriteLine("Es un nombre inválido.");
                        }
                    } while (nombre == null || nombre == "");
                    do
                    {
                        Console.Write("Categoría a la que pertenece el producto: ");
                        categoria = Console.ReadLine();
                        if (categoria == null || categoria == "")
                        {
                            Console.WriteLine("Es una categoría inválida.");
                        }
                    } while (categoria == null || categoria == "");
                    do
                    {
                        Console.Write("Precio del producto: ");
                        precio = double.Parse(Console.ReadLine());
                        if (precio == null)
                        {
                            Console.WriteLine("Es un precio inválido.");
                        }
                    } while (precio == null);
                    do
                    {
                        Console.Write("Ranking del producto: ");
                        ranking = int.Parse(Console.ReadLine());
                        if (ranking == null)
                        {
                            Console.WriteLine("Es un ranking inválido.");
                        }
                    } while (ranking == null);
                    Producto producto = new Producto(id, nombre, categoria, precio, ranking);
                    _productos.Add(producto);
                    Console.WriteLine("Producto agregada correctamente.");
                    Console.WriteLine("Presiona enter para continuar.");
                    Console.ReadLine();
                    showMenuPrincipal();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Ranking de producto.");
                    Console.WriteLine("\n");
                    id = null;
                    do
                    {
                        Console.WriteLine("Escriba el id del prodcuto.");
                        id = int.Parse(Console.ReadLine());
                        if (id == null)
                        {
                            Console.WriteLine("Es un id inválido.");
                        }
                    } while (id == null);
                    Producto? productoBuscar = _productos.FirstOrDefault(p => p.id == id);
                    if (productoBuscar == null)
                    {
                        Console.WriteLine("Esta id no existe. Presiona enter para continuar.");
                        Console.ReadLine();
                        showMenuPrincipal();
                    }
                    else
                    {
                        Console.WriteLine("" + productoBuscar.rankingProducto());
                        Console.WriteLine("Presiona enter para continuar.");
                        Console.ReadLine();
                        showMenuPrincipal();
                    }
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Eliminar producto.");
                    Console.WriteLine("\n");
                    id = null;
                    do
                    {
                        Console.WriteLine("Escriba el id del producto a eliminar.");
                        id = int.Parse(Console.ReadLine());
                        if (id == null)
                        {
                            Console.WriteLine("Es un nombre inválido.");
                        }
                    } while (id == null);
                    Producto? proEliminacion = _productos.FirstOrDefault(p => p.id == id);
                    if (proEliminacion == null)
                    {
                        Console.WriteLine("Esta película no existe dentro de la colección. Presiona enter para continuar.");
                        Console.ReadLine();
                        showMenuPrincipal();
                    }
                    else
                    {
                        _productos.Remove(proEliminacion);
                        Console.WriteLine("El producto con id: " + id + " se eliminó correctamente. Presiona enter para continuar.");
                        Console.ReadLine();
                        showMenuPrincipal();
                    }
                    break;
                case 5:
                    break;
            }
        }
        private void ListarProductos()
        {
            Console.WriteLine("Lista de productos.");
            Console.WriteLine("\n");
            foreach (Producto item in _productos)
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
                    Console.Clear();
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
