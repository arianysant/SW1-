namespace projeto_conta;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto banco!");
        Conta c = new Conta();  //instanciar uma classe
        //c.Saldo = 1000; 
        c.Depositar(1000);  
        c.Sacar (83000);        //atribuir valor
        //c.Limite = 500;
        c.AjustarLimite(500);
        double ValorTotal = c.MostrarSaldo();


       // Console.WriteLine("Seu saldo é de: " + c.Saldo + " Com limite de: " + c.Limite);
        Console.WriteLine("Seu saldo total é de: " + ValorTotal);
        //Console.WriteLine("Seu saldo total é de: " + c.Saldo);
    }
}
