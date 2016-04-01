using System;

namespace utilizando_flag
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<Status> estahAprovado = (status) => Console.WriteLine("O status {0} é aprovado? {1}", status, status.HasFlag(Status.Aprovado));

            estahAprovado(Status.AguardandoAprovacao);
            estahAprovado(Status.Rejeitado);
            estahAprovado(Status.Cancelado);
            estahAprovado(Status.Aprovado);
            estahAprovado(Status.ParcialmenteAtendido);
            estahAprovado(Status.TotalmenteAtendido);
            estahAprovado(Status.EmAtendimento);
            
            Console.ReadKey();
        }
    }
}
