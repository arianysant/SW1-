namespace _03;
class ContratoPessoaFisica:Contrato
{
  public string? Cpf {get;set;}
   public string? Idade {get;set;}
   

   public virtual string MostraDados(){

    return base.MostraDados() + " - " +  this.Cpf + "-" + this.Idade;
 }

    public override double CalcularPrestacao(double valor, int prazo)
    {
        double adicional = 0;
        if (this.Idade <= 30){
            adicional = 1;
        }
        else if (this.Idade <= 40){
            adicional = 2;
        }

        else if (this.Idade <= 50){
            adicional = 3;
        }
        else if (this.Idade > 50){
            adicional = 4;
        }
        return base.CalcularPrestacao(valor, prazo)+ adicional;
    }
}