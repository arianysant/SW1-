namespace _03;
class Contrato
{
    public string? Nome {get;set;}
    public string? Email {get;set;}
    public string? Telefone {get;set;}

    public virtual string MostraDados(){
        String Tudo = this.Nome + " ---- " + this.Email + " ---- " + this.Telefone;
        return Tudo;
    }

    public virtual double CalcularPrestacao(double valor, int prazo){
        double parcela = valor/prazo;

        return parcela;
    }
}