using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };

        Console.WriteLine("Arreglo:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("\n\nIngrese el número a buscar:");
        int target = int.Parse(Console.ReadLine()!);

        // Búsqueda Lineal
        int resultadoLineal = BusquedaLineal(array, target);

        if (resultadoLineal != -1)
            Console.WriteLine("Búsqueda Lineal: Encontrado en posición " + resultadoLineal);
        else
            Console.WriteLine("Búsqueda Lineal: No encontrado");

        // Búsqueda Binaria
        int resultadoBinaria = BusquedaBinaria(array, target);

        if (resultadoBinaria != -1)
            Console.WriteLine("Búsqueda Binaria: Encontrado en posición " + resultadoBinaria);
        else
            Console.WriteLine("Búsqueda Binaria: No encontrado");
    }

    static int BusquedaLineal(int[] array, int target)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
                return i;
        }

        return -1;
    }

    static int BusquedaBinaria(int[] array, int target)
    {
        int low = 0;
        int high = array.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (array[mid] == target)
                return mid;
            else if (array[mid] < target)
                low = mid + 1;
            else
                high = mid - 1;
        }

        return -1;
    }
}