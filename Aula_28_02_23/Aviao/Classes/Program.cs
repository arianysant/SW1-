namespace ex_aviao;

class Program{
    static void Main(string[] args){
        
        Console.WriteLine("Exercicio Aviao POO");
        Aviao aviao01 = new Aviao();

        aviao01.modelo = "Airbus A330";
        aviao01.marca = "TAM";
        
        aviao01.exibir();
        aviao01.acelerar();
        aviao01.exibir();
        aviao01.acelerar();
        aviao01.exibir();
        
    }
}
