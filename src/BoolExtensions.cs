namespace ObserverPattern
{
    public static class BoolExtensions
    {
        public static string Humanizar(this bool valor)
        {
            return valor ? "sim" : "não";
        }
    }
}