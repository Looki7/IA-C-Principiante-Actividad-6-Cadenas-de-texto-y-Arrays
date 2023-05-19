// Actividad 6 


/*

1. Escribe un programa que declare e inicialice un array de números de
tamaño 5. Luego, recorre el array y muestra por consola cada uno de los
elementos.

*/


public static class Program
{
    public static void Main()
    {
        int[] mynum = {4,7,5,8,6};
        foreach (int i in mynum)
        {
            Console.Write(i + " ");
        }
    }
}


/*

2. Escribe un programa que pida al usuario que introduzca una cadena de
texto y luego muestre por consola la longitud de la cadena.

*/


public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Introduzca aquí su texto:");
        string texto = Console.ReadLine();

        string array;
        array = texto;

        Console.WriteLine("");
        Console.WriteLine($"Ha escrito {texto.Length} palabras.");
    }
}


/*
 
3. Escribe un programa que pida al usuario que introduzca una cadena de
texto y luego muestre por consola la misma cadena pero en mayúsculas.

*/


public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Introduzca su texto:");

        string texto = Console.ReadLine().ToUpper();

        Console.WriteLine("");
        Console.WriteLine("Su texto en mayúsculas: \n" + texto);
    }
}


/*
 
4. Escribe un programa que pida al usuario que introduzca dos cadenas
de texto y luego las concatene en una tercera cadena. Muestra por consola
la cadena resultante.

*/


public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Ingrese la primera cadena de texto: ");
        string cadena1 = Console.ReadLine();

        Console.WriteLine("Ingrese la segunda cadena de texto: ");
        string cadena2 = Console.ReadLine();

        string cadenaConcatenada = cadena1 + cadena2;

        Console.WriteLine($"La cadena final es: {cadenaConcatenada}");
    }
}


/*
 
5. Escribe un programa que declare e inicialice un array de cadenas
con 5 nombres de ciudades. Luego, recorre el array y muestra por consola
cada una de las ciudades.

*/


public static class Program
{
    public static void Main()
    {
        string[] ciudades = {"Barcelona","Madrid","Londres","Zaragoza",
                             "Bibao"};

        foreach (string i in ciudades)
        {
            Console.Write($" {i}");
        }
    }
}


/*
 
6. Escribe un programa que declare e inicialice un array de números
enteros de tamaño 10. Luego, recorre el array y muestra por consola la
suma de todos los elementos.

*/


public static class Program
{
    public static void Main()
    {
        int[] numeros = {6,7,8,5,45,67,76,90,65,32};
        Console.WriteLine($"Resultado: {numeros.Sum()}");
    }
}


/*
 
7. Escribe un programa que pida al usuario que introduzca una
cadena de texto y un carácter. Luego, muestra por consola cuántas
veces aparece el carácter en la cadena.

*/


public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Introduzca una cadena de texto: ");
        string cadenaTexto = Console.ReadLine();

        Console.WriteLine("Introduzca un carácter: ");
        char caracter = char.Parse(Console.ReadLine());

        int frequencia = cadenaTexto.Count(f => (f == caracter));
        Console.WriteLine($"El carácter aparece {frequencia} veces.");
    }
}


/*

8. Escribe un programa que declare e inicialice un array de números
enteros de tamaño 10. Luego, recorre el array y muestra por consola el
valor máximo y el valor mínimo.

*/


public static class Program
{
    public static void Main()
    {
        int[] num = { 1, 5, 4, 6, 8, 7, 0, 2, 16, 89 };
        Console.WriteLine($"Valor máximo: {num.Max()}");
        Console.WriteLine($"Valor mínimo: {num.Min()}");
    }
}


/*

9. Escribe un programa que pida al usuario que introduzca una cadena de
texto y luego muestre por consola la misma cadena pero invertida (es
decir, que el último carácter aparezca primero, y así sucesivamente).

*/


public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Introduzca una cadena de texto: ");
        string texto = Console.ReadLine();
        string textoInvertido = new string(texto.ToCharArray().Reverse()
                                .ToArray());
        Console.WriteLine($"Texto invertido: {textoInvertido}");
    }
}


/*
 
10. Escribe un programa que declare e inicialice un array de cadenas
con 5 nombres de frutas. Luego, pide al usuario que introduzca un nombre
de fruta y muestra por consola si el array contiene esa fruta o no.

*/


public static class Program
{
    public static void Main()
    {
        string[] frutas = {"fresa","manzana","pera","uva","plátano"};

        Console.Write("Escriba el nombre de una fruta: ");
        bool contieneFruta = frutas.Contains(Console.ReadLine()
                            .ToLower());

        if (contieneFruta)
        {
            Console.WriteLine("El array contiene esa fruta");
        }
        else
        {
            Console.WriteLine("El array no contiene esa fruta.");
        }
    }
}