namespace _02;
class Contrato
{
   public string? Nome {get;set;}
   public string? Tipo {get;set;}
   public string? Telefone {get;set;}

   public virtual string MostraDados(){
    string Tudo = this.Nome + " ---- " + this.Tipo + " ---- " +  this.Telefone;
    return Tudo;
   }
}