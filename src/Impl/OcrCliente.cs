namespace ObserverPattern.Impl
{
    using System;

    /// <summary>
    /// Observer
    /// </summary>
    public class OcrCliente : IClienteFila
    {
        private IFila fila = new FilaOcr();

        public void AtualizarInformacoes(IFila fila)
        {
            this.fila = fila;
            Console.WriteLine("Fila possui " + fila.Itens + " itens. pode-se disparar job de requisição e reconhecimento aqui");
        }

        public bool TemItens()
        {
            return this.fila.Itens > 0;
        }

        public int PegarUmItem()
        {
            return fila.RetornaItem();
        }
    }
}