using System;

namespace MyApp
{
  class Program
  {
    static void Main(string[] args)
    {
      // var id = Guid.NewGuid();
      // id.ToString();
      // Console.WriteLine(id);

      var price = 10.2;
      //var texto = "O preco do produto é " + price;
      var texto = string.Format("O preço do produto é {0} apenas na promoção", price);

      Console.WriteLine(texto);
    }
  }
}
