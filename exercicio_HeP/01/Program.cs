namespace Herança_e_Polimorfismo;
class Program
{
 static void Main(string[] args)
    {
       Animal a = new Animal();
        Homem h = new Homem();
          Cao c = new Cao();
         Gato g = new Gato();


        Console.WriteLine("Homem: " + h.Fala());
        Console.WriteLine("Cão: " + c.Fala());
        Console.WriteLine("Gato: " + g.Fala());
    }
}
