namespace _03;
class Program
{
     static void Main(string[] args)
    {
        Contrato c = new Contrato();
        ContratoPessoaFisica fisica = new ContratoPessoaFisica();
        ContratoPessoaJuri juri = new ContratoPessoaJuri();

        fisica.Tipo = "Pessoa Física";
        fisica.Idade = 16;
        fisica.Cpf = 00000000000;
        fisica.Prazo = 10;
        

        juri.Tipo = "Pessoa Jurídica";
        juri.Cnpj = 0000000001;
        juri.inscricao = 123456789;
        juri.Prazo = 10;
        
      
      
       
        Console.WriteLine
        ("O contrato é: " + fisica.Tipo + "// A idade Idade: " + fisica.Idade + "// O CPF: " + fisica.Cpf  + "// Valor: " + c.CalcularPrestacao() + "// Prazo: "+ fisica.Prazo + "// Prestações: " + fisica.CalcularPrestacao());
        
        Console.WriteLine
        ("O contrato é: " + juri.Tipo + "// cnpj: " + juri.Cnpj + "// Inscrição: " + juri.inscricao  + "// Contrato: " + c.CalcularPrestacao() + "// Prazo: " + juri.Prazo + "// Prestações: " + juri.CalcularPrestacao());
      
    }
}
    
