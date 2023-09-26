using System;

namespace MetodosAbs
{
  class Program
  {
    static void Main(string[] args)
    {
      //nao instanciado, classes com metodos e atributos estáticos
      Exemplo.Soma(5, 5);
      Console.WriteLine("seu nome é: "+ Exemplo.nome);
    }
  }
}
