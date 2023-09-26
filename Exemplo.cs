using System;

class Exemplo
{
  //classes abstratas não precisam ser instanciadas
  //atributo abstrato
  public static string nome = "diego";

  //metodo abstrato
  public static void Soma(int num1, int num2){
    Console.WriteLine(num1 + num2);
  }
}