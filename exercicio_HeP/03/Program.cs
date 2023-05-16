namespace _03;
class Program
{
    static void Main(string[] args)
    {
        ContratoPessoaFisica fisica = new ContratoPessoaFisica();

        Console.WriteLine("Cadastro da pessoa fisica: ");
        Console.WriteLine("Informe o nome da pessoa: ");
        fisica.Nome = Console.ReadLine();
        Console.WriteLine("Informe o email da pessoa: ");
        fisica.Email = Console.ReadLine();
        Console.WriteLine("Informe o CPF da pessoa: ");
        fisica.Cpf = Console.ReadLine();
        Console.WriteLine("Informe a idade da pessoa: ");
        fisica.idade = Console.ReadLine();
        Console.WriteLine("Informe o telefone da pessoa: ");
        fisica.Telefone = Console.ReadLine();

        Console.ReadKey();
    }
}
