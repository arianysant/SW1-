namespace exercicio;
class Program
{
    static void Main(string[] args)
    {
        Banco b = new Banco();

        b.imprime (b.dividir(1000,12));
        //incompleto
        //b.imprime (b.taxa(1000, 6));
    }
}
