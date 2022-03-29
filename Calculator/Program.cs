using System;

namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Soma();
      Subtracao();
    }

    static void Soma()
    {
      Console.Clear();
      Console.WriteLine("Primeiro valor da soma: ");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor da soma: ");
      float v2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float resultado = v1 + v2;
      Console.WriteLine("O resultado da soma é " + resultado);
      Console.WriteLine($"O resultado da soma é {resultado}");
      Console.WriteLine($"O resultado da soma é {v1 + v2}");
      Console.ReadKey();
    }

    static void Subtracao()
    {
      Console.Clear();

      Console.WriteLine("Primeiro valor da subtração: ");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor da subtração: ");
      float v2 = float.Parse(Console.ReadLine());

      float resultado = v1 - v2;

      Console.WriteLine($"O resultado da subtração é {resultado}");
      Console.ReadKey();
    }
  }


}
