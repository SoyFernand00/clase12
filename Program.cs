﻿using s12practica;

byte opcion;
string regresar;
estudiantes e=new estudiantes();
do
{
    Console.WriteLine("\tBIENVENIDOS");
    Console.WriteLine("*******MENU*******");
    Console.WriteLine("[1] Insertar");
    Console.WriteLine("[2] Mostrar");
    Console.WriteLine("[3] Eliminar");
    Console.WriteLine("[4] Ordenar");
    Console.WriteLine("[0] Salir");
    Console.WriteLine();

    Console.WriteLine("Ingrese opcion: ");
    while (!byte.TryParse(Console.ReadLine(), out opcion) || opcion > 4)
    {
        Console.WriteLine("Error: Ingrese valor: ");
    }

    switch (opcion)
    {
        case 0:
            Environment.Exit(0); break;
        case 1:
            e.insertar(); break;
        case 2:
            e.mostrar(); break;
        case 3:
            Console.Write("\nIngresa edad a eliminar: ");
            byte ed=byte.Parse(Console.ReadLine());
            e.eliminar(ed);
            break;
        case 4:

            break;
    }
    Console.WriteLine();
    Console.Write("\nDesea regresar al menu? [si]: ");
    regresar = Console.ReadLine().ToLower();
    Console.Clear();
} while (regresar == "si");