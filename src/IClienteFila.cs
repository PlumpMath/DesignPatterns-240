namespace ObserverPattern
{
    public interface IClienteFila
    {
        void AtualizarInformacoes(IFila fila);

        bool TemItens();

        int PegarUmItem();
    }
}