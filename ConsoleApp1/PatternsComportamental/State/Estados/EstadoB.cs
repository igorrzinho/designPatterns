using DesignPatterns.PatternsComportamental.State.Interfaces;

namespace DesignPatterns.PatternsComportamental.State.Estados;

public class EstadoB : IEstado
{
    public void Acoes(Context context)
    {
        Console.WriteLine("Ações do Estado B");
        context.Estado = new EstadoA();
    }
}