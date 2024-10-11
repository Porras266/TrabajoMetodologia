using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{

    /*El siguiente programa solicitara cuantos numeros almacenara, el valor de los numeros, creara el arreglo 
    Y utilizara El metodo "Divide y Venceras" para encontrar el numero maximo*/
    static int EncontrarMayor(int[] Numeros, int Izquierda, int Derecha)
    {
        // Caso base: si el Arreglo tiene un solo elemento
        if (Izquierda == Derecha)
        {
            return Numeros[Izquierda];
        }

        // Dividir el Arreglo en dos mitades
        int mid = (Izquierda + Derecha) / 2;

        // Conquistar: encontrar el máximo en cada mitad
        int MaxIzquierda = EncontrarMayor(Numeros, Izquierda, mid);
        int MaxDerecha = EncontrarMayor(Numeros, mid + 1, Derecha);

        // Combinar: devolver el máximo de las dos mitades
        return Math.Max(MaxIzquierda, MaxDerecha);
    }

    static void Main()
    {
        // Se le solicita al usuario Ingresar cuantos numeros va a ingresar en el arreglo para buscar
        Console.WriteLine("Ingrese la cantidad de números que desea ingresar:");
        int cantidad = int.Parse(Console.ReadLine());

        //Crea el arreglo Y lo crea del tamaño que se solicito antes 
        int[] Numeros = new int[cantidad];

        // Se crea un for para ingresar la cantidad en el arreglo
        for (int i = 0; i < cantidad; i++)
        {
            // Se imprime la solicitud de los numeros que se desea buscar y el (i + 1) es para que se imprima en consola la posicion del numero que vas a guardar
            Console.WriteLine("Ingrese el número en la posición " + (i + 1) + ":");
            Numeros[i] = int.Parse(Console.ReadLine());
        }

        //se utiliza el el Static int que creamos antes 
        int Maximo = EncontrarMayor(Numeros, 0, Numeros.Length - 1);
        // Se imprime cual es el numero maximo 
        Console.WriteLine("El número máximo es: " + Maximo);
    }
}
