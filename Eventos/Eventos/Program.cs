using Eventos.Models;

namespace Eventos
{
    class Program
    {
        public static void Main(string[] args)
        {
            Matematica m = new Matematica(10, 20);
            m.Somar();
        }
    }
}