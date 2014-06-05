namespace ObserverPattern
{
    public interface IFila
    {
        int Itens { get; set; }

        void AdicionarObservador(IClienteFila clienteFila);

        void Remover(IClienteFila clienteFila);

        void NotificarObservadores();

        int RetornaItem();
    }
}