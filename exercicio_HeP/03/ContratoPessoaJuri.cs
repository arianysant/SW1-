namespace _03;

class ContratoPessoaJuri:Contrato
{

public override double CalcularPrestacao(){
    return ((base.CalcularPrestacao()/Prazo)+3);
   } 
}

