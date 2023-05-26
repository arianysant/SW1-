namespace _03;
class Program
{
    static void Main(string[] args)
    {
        Contrato c = new Contrato();
        ContratoPessoaFisica fisica = new ContratoPessoaFisica();
        ContratoPessoaJuri juri = new ContratoPessoaJuri();

        fisica.Tipo = "Pessoa Física";
        fisica.Nome = "Ariany";
        fisica.Idade = 10;
        fisica.Cpf = 12345678910;
        fisica.Prazo = 10;
    //--------------------------------------------------//
        juri.Tipo = "Pessoa Jurídica";
        juri.Nome = "Andrade";
        juri.Cnpj = 0006543210;
        juri.IE= 1234567890;
        juri.Prazo = 10;
        
        
             //fisica//

        Console.WriteLine("Tipo de pessoa: " + fisica.Tipo );
        Console.WriteLine("Nome: " + fisica.Nome );
        Console.WriteLine("Idade da pessoa: " + fisica.Idade);
        Console.WriteLine("CPF da pessoa: " + fisica.Cpf);
        Console.WriteLine("Valor do contrato: " + c.CalcularPrestacao());
        Console.WriteLine("O prazo é: " + fisica.Prazo);
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("----------------------------------------");

             //juridica//
               
        Console.WriteLine("Tipo de pessoa: " + juri.Tipo );
        Console.WriteLine("Nome: " + juri.Nome );
        Console.WriteLine("Inscrição Estadual: " + juri.IE);
        Console.WriteLine("Cnpj da pessoa: " + juri.Cnpj);
        Console.WriteLine("Valor do contrato: " + c.CalcularPrestacao());
        Console.WriteLine("O prazo é: " + juri.Prazo);
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Obrigado.");



        Console.ReadKey();
    }
}
