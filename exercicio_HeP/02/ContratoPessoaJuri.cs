namespace _02;
class ContratoPessoaJuri:Contrato
{
 public string? Cnpj {get;set;}
  public string? IE {get;set;}
   

   public override string MostraDados(){

    return base.MostraDados() + " ---- CNPJ:" +  this.Cnpj + " ---- IE:" + this.IE;
}
}
