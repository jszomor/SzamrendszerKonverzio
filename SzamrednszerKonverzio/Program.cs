using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzamrednszerKonverzio
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Kérem a tizes számrendszerbeli számot!");
      int szam;
      szam = int.Parse(Console.ReadLine());
      Console.WriteLine("Hanyas szamrendszerbe keri az átváltást?");
      int valasztottSzamrendszer;
      valasztottSzamrendszer = int.Parse(Console.ReadLine());

      List<int> eredmeny = new List<int>();
      int maradek;
      while(szam>0)
      {
        maradek = szam % valasztottSzamrendszer;
        szam /= valasztottSzamrendszer;
        eredmeny.Add(maradek);
      }
      Console.WriteLine("A kért átváltás ereménye:");
      for (int i = eredmeny.Count - 1; i >= 0; i--)
      {
        Console.Write(eredmeny[i]);
      }
      Console.ReadKey();
    }
  }
}
