namespace Herança_e_Polimorfismo;

class Cao:Animal
{
    public override string Fala(){
       return base.Fala() + "Au Au";
    }
}