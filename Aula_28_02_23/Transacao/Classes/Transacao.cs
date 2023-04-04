namespace ex_transacao;

class Transacao{

    public string agencia = "";
    public string tipo = "";
    public int valor;
    public int conta;

    private void sacar(){
        valor--;
    }

    private void transferir(){
        valor--;
    }

    protected void consultar(){
        conta--;
    }

    public void depositar(){
        valor++;
    }

    }