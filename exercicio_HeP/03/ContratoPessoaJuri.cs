namespace _03;

class ContratoPessoaJuri:Contrato
{
public string? Cnpj {get;set;}
public string? IE {get;set;}
public string? NomeEmpresa {get;set;}

//----------------------------------------------------//

public override string MostraDados()
{
    return base.MostraDados()+" ---- "+this.Cnpj+ " ---- " + this.IE+ " ---- " + this.NomeEmpresa;
}

public override double CalcularPrestacao(double valor, int prazo)
{
  return base.CalcularPrestacao(valor, prazo) + 3;
}
}
