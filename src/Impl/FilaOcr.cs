namespace ObserverPattern.Impl
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Subject
    /// </summary>
    public class FilaOcr : IFila
    {
        private readonly IList<IClienteFila> observadores;
        private readonly Queue<int> fila;

        public FilaOcr()
        {
            this.observadores = new List<IClienteFila>();
            this.fila = new Queue<int>();
        }

        public int Itens
        {
            get
            {
                return this.fila.Count;
            }
            
            set
            {
                this.Itens = value;
            }
        }

        public void AdicionarObservador(IClienteFila clienteFila)
        {
            this.observadores.Add(clienteFila);
        }

        public void Remover(IClienteFila clienteFila)
        {
            this.observadores.Remove(clienteFila);
        }
        
        public void PopularFila()
        {
            Parallel.For(0, 100, this.fila.Enqueue);
            this.NotificarObservadores();
        }

        public void NotificarObservadores()
        {
            foreach (var observador in observadores)
            {
                observador.AtualizarInformacoes(this);
            }
        }

        public int RetornaItem()
        {
            return this.fila.Dequeue();
        }
    }
}