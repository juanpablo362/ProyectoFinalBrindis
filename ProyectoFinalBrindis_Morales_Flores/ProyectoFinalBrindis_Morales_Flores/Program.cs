using ProyectoFinalBrindis_Morales_Flores;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;

namespace ProyectoFinalBrindis_Morales_Flores
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("MENU PROYECTO FINAL");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("1.- Listas");
                Console.WriteLine("2.- Pilas");
                Console.WriteLine("3.- Colas");
                Console.WriteLine("4.- Árboles");
                Console.WriteLine("5.- Salir");
                Console.WriteLine("---------------------------------------");
                Console.Write("Seleccionar Opción => ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        MenuListas();
                        break;
                    case 2:
                        MenuPilas();
                        break;
                    case 3:
                        MenuColas();
                        break;
                    case 4:
                        MenuArboles();
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }
            } while (opcion != 5);
            Console.Clear ();
        }

        static void MenuListas()
        {
            Listas milista = new Listas(); // Creamos una nueva lista vacía.
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("MENU LISTAS\n---------------------------------\n1.- Insertar Nodo\n2.- Imprimir Tamaño\n3.- Buscar Nodo por Posición");
                Console.WriteLine("4.- Borrar Nodo\n5.- Modificar Nodo\n6.- Buscar Nodo por Valor\n7.- Imprimir Lista\n8.- Regresar al menu principal\nSeleccionar Opción => ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Write("Teclear valor del nodo a insertar: ");
                        int valorInsertar = Convert.ToInt32(Console.ReadLine());
                        milista.Add(valorInsertar);
                        Console.WriteLine("Nodo insertado correctamente.");
                        break;
                    case 2:
                        int tamano = milista.Count();
                        Console.WriteLine($"La lista tiene {tamano} nodos.");
                        break;
                    case 3:
                        // Opción para buscar un nodo por su posición.
                        Console.Write("Dame la posición del nodo a buscar: ");
                        int posBuscar = Convert.ToInt32(Console.ReadLine());
                        int valorNodo = milista.Find(posBuscar);
                        if (valorNodo != -1)
                            Console.WriteLine($"El valor en la posición {posBuscar} es: {valorNodo}");
                        else
                            Console.WriteLine("Posición no válida.");
                        break;

                    case 4:
                        // Opción para borrar un nodo por su posición.
                        Console.Write("Dame la posición del nodo a borrar: ");
                        int posBorrar = Convert.ToInt32(Console.ReadLine());
                        if (milista.Delete(posBorrar))
                            Console.WriteLine("Nodo borrado correctamente.");
                        else
                            Console.WriteLine("Posición no válida o lista vacía.");
                        break;
                    case 5:
                        // Opción para modificar el valor de un nodo.
                        Console.Write("Dame la posición del nodo a modificar: ");
                        int posModificar = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Dame el nuevo valor: ");
                        int nuevoValor = Convert.ToInt32(Console.ReadLine());
                        if (milista.Change(posModificar, nuevoValor))
                            Console.WriteLine("Nodo modificado correctamente.");
                        else
                            Console.WriteLine("No se pudo modificar el nodo.");
                        break;
                    case 6:
                        // Opción para buscar un nodo por su valor.
                        Console.Write("Dame el valor a buscar: ");
                        int valorBuscar = Convert.ToInt32(Console.ReadLine());
                        int posicion = milista.FindValue(valorBuscar);
                        if (posicion != -1)
                            Console.WriteLine($"El valor {valorBuscar} está en la posición { posicion}.");
                        else
                            Console.WriteLine("Valor no encontrado.");
                        break;
                    case 7:
                        Console.WriteLine("Contenido de la lista:");
                        milista.print();
                        break;
                    case 8:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.WriteLine("Presiona Enter para continuar...");
                Console.ReadLine();
            } while (opcion != 8);
        }

        static void MenuPilas()
        {
            Pilas pila = null;
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("\r\nMENU Pilas\r\n---------------------------------\r\n1.- Establecer Tamaño\r\n2.- Push\r\n3.- Pop\r\n4.- Imprimir \r\n5.- Regresar al menu principal\r\n_____________________\r\nSelecciónar Opción => ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Dame el tamaño de la pila");
                        pila = new Pilas(Convert.ToInt32(Console.ReadLine()));
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Write("Ingresa un número para agregar a la pila: ");
                        if (pila != null &&

                        pila.Push(Convert.ToInt32(Console.ReadLine())))

                        {
                            Console.WriteLine("Elemento agregado exitosamente.");
                        }

                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        if (pila != null)
                        {
                            int valor = pila.Pop();
                            if (valor != -1)
                            {
                                Console.WriteLine("Elemento extraído: " + valor);
                            }
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case 4:
                        pila?.Print();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del programa...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Opción no válida, intente de nuevo.");
                        break;
                }
            } while (opcion != 5);
        }

        static void MenuColas()
        {
            Colas cola = null;
            int tamaño = 0;
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("MENU Colas\r\n---------------------------------\r\n1.- Establecer Tamaño\r\n2.- Imprimir conteo\r\n3.- Insert\r\n4.- Extract\r\n5.- Imprimir Cola\r\n6.- Regresar al menu principal\r\n_____________________\r\nSelecciónar Opción => ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el tamaño de la cola: ");
                        tamaño = Convert.ToInt32(Console.ReadLine());
                        cola = new Colas(tamaño);
                        Console.WriteLine($"Tamaño de la cola fue establecido a {tamaño}");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        if (cola != null)
                        {
                            Console.WriteLine($"La cola tiene {cola.Count()} valores");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else

                        {
                            Console.WriteLine("Primero debes asignarle un número a la cola");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case 3:
                        if (cola != null)
                        {
                            Console.Write("Dame el valor a insertar: ");
                            int valor = Convert.ToInt32(Console.ReadLine());
                            if (cola.Insert(valor))
                            {
                                Console.WriteLine($"Valor insertado: {valor}");
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("Error: La cola esta llena");
                                Console.ReadLine();
                                Console.Clear();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Primero debes asignarle un número a la cola");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case 4:
                        if (cola != null)
                        {
                            int Extraer = cola.Extract();
                            if (Extraer != -1)
                            {
                                Console.WriteLine($"Se extrajo: {Extraer}");
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("Error: No se puede extraer por que la pila esta vacía");
                                

                                Console.ReadLine();

                                Console.Clear();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Primero debes asignarle un número a la cola.");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case 5:
                        if (cola != null)
                        {
                            cola.Print();
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Primero debes asignarle un número a la cola.");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case 6:
                        Console.ReadLine();
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Ingrese un número entre el 1 y 6.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }

            } while (opcion != 8);
        }

        static void MenuArboles()
        {
            int opcion;
            Arbol arbol = new Arbol();
            do
            {
                Console.Clear();
                Console.WriteLine("MENÚ ÁRBOLES");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("1.- Insertar nodo");
                Console.WriteLine("2.- Tamaño");
                Console.WriteLine("3.- Altura");
                Console.WriteLine("4.- LRP");
                Console.WriteLine("5.- Recorrido");
                Console.WriteLine("6.- Regresar al menu principal");
                Console.WriteLine("---------------------------------------");
                Console.Write("Seleccionar Opción => ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el valor del nodo: ");
                        int valor = Convert.ToInt32(Console.ReadLine());
                        arbol.Insertar(valor);
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine($"El tamaño del árbol es: {arbol.Tamano(arbol.raiz)}");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine($"La altura del árbol es: {arbol.Altura(arbol.raiz)}");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("Recorrido LRP");
                        arbol.LRP();
                        Console.WriteLine();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("Recorrido en preorden:");
                        arbol.Recorrido(arbol.raiz);
                        Console.WriteLine();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 6:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Inténtelo de nuevo.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            } while (opcion != 6);

        }
    }
}
