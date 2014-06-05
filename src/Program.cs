namespace ObserverPattern
{
    using System;
    using Impl;

    public class Program
    {
        public static void Main(string[] args)
        {
            /// criamos uma fila.
            var filaOcr = new FilaOcr();

            var ocrMaquina1 = new OcrCliente();
            var ocrMaquina2 = new OcrCliente();
            
            //// informamos clientes
            filaOcr.AdicionarObservador(ocrMaquina1);
            filaOcr.AdicionarObservador(ocrMaquina2);

            Console.WriteLine("fila tem item? " + ocrMaquina1.TemItens().Humanizar());
            Console.WriteLine("fila tem item? " + ocrMaquina2.TemItens().Humanizar());
            Console.WriteLine(" ");

            Console.ReadKey();

            ////situação que muda o estado da fila e que deve notificar os observadores
            filaOcr.PopularFila();
            
            Console.ReadKey();

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("fila 1 pede? " + ocrMaquina1.PegarUmItem());
                Console.WriteLine("fila 2 pede? " + ocrMaquina2.PegarUmItem());
                Console.WriteLine(" ");
            }

            Console.ReadKey();

            Console.WriteLine("fila tem item? " + ocrMaquina1.TemItens().Humanizar());
            Console.WriteLine("fila tem item? " + ocrMaquina2.TemItens().Humanizar());
            Console.WriteLine(" ");

            Console.ReadKey();
        }
    }
}
