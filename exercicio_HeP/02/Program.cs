namespace _02;
class Program
{
    static void Main(string[] args)
    {
       ContratoPessoaFisica fisica = new ContratoPessoaFisica();
       ContratoPessoaJuri juri = new ContratoPessoaJuri();

       fisica.Nome = "Ariany";
       fisica.Cpf = "123.456.789-00";
       fisica.Idade = "16";

       Console.WriteLine("OS dados das Pessoa Física:");
       Console.WriteLine(fisica.MostraDados());
       Console.WriteLine("--------------------------------------------");

       //parte pessoa juridica  //

       juri.Nome = "Andrade";
       juri.Cnpj = "00.123.000/0000-00";
       juri.IE = "0000.000.0000-00";


       Console.WriteLine("OS dados da Pessoa Juridica:");
       Console.WriteLine(juri.MostraDados());
       Console.WriteLine("----------------------------------------------"); 

       Console.ReadKey();
    }
}
