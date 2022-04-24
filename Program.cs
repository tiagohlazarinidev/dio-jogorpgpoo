using System;
using JogoRpg.src.Entities;

namespace JogoRpg
{
  class Program
  {
    public static void Main()
    {
      Knight arus = new("Arus", 23, "Knight", 500, 100);
      Wizard wizard = new("Jennica", 23, "White Wizard", 500, 100);

      Console.WriteLine(wizard.Attack(1));
      Console.WriteLine(wizard.Attack(7));
    }
  }
}