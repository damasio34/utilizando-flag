using System;

namespace utilizando_flag
{
    [Flags]
    public enum Status
    {
        AguardandoAprovacao = 0,
        Rejeitado = 1,
        Cancelado = 2,
        Aprovado = 64,
        ParcialmenteAtendido = Aprovado + 9,
        TotalmenteAtendido = Aprovado + 2,
        EmAtendimento = Aprovado + 3
    }
}
