using System;

namespace JuegoTablero
{
    class Rey : Pieza
    {
        public Rey(int numeroJugador)
            : base(
                "Rey",
                ObtenerSimbolo(numeroJugador),
                numeroJugador
            )
        {
        }

        public static char ObtenerSimbolo(
            int numeroJugador
        )
        {
            if (numeroJugador == 1)
            {
                return 'R';
            }
            else
            {
                return 'r';
            }
        }

        public override bool MovimientoValido(
            int fo,
            int co,
            int fd,
            int cd,
            Pieza[,] tablero
        )
        {
            int diferenciaFila =
                Math.Abs(fd - fo);

            int diferenciaColumna =
                Math.Abs(cd - co);

            return (
                diferenciaFila <= 1 &&
                diferenciaColumna <= 1
            );
        }
    }
}