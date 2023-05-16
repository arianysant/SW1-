namespace EXERCICIO_02;
class Program
{
    static void Main(string[] args)
    {
       ContratoPessoaFisica fisica = new ContratoPessoaFisica();

       fisica.Nome = "Ariany";
       fisica.Email = "email@email.com";
       fisica.Cpf = "123.456.789-00";
       fisica.Idade = "16";
       fisica.Telefone = "(11) 99999-9999";

       Console.WriteLine("OS dados das Pessoa Física:");
       Console.WriteLine(fisica.MostraDados());
       Console.WriteLine("--------------------------------------------");

       //parte pessoa juridica  //

       ContratoPessoaJuri juri = new ContratoPessoaJuri();

       juri.Nome = "Ariany";
       juri.Email = "email@email.com";
       juri.Cnpj = "00.123.000/0000-00";
       juri.IE = "0000.000.0000-00";
       juri.NomeEmpresa = "Andrade";
       juri.Telefone = "(11) 99999-9999";

       Console.WriteLine("OS dados da Pessoa Juridica:");
       Console.WriteLine(fisica.MostraDados());
       Console.WriteLine("----------------------------------------------"); 

       Console.ReadKey();
    }
}
