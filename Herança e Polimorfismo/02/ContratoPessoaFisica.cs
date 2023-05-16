namespace _02;

class ContratoPessoaFisica:Contrato
{
  public string? Cpf {get;set;}
   public string? Idade {get;set;}
   

   public virtual string MostraDados(){

    return base.MostraDados() + " - " +  this.Cpf + "-" + this.Idade;
}
}