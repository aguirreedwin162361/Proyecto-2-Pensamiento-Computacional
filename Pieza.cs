namespace JuegoTablero
{
    abstract class Pieza
    {
        protected string nombre;
        protected char simbolo;
        protected int jugador;

        public Pieza(string nombrePieza, char simboloPieza,int numeroJugador)
        {
            nombre = nombrePieza;
            simbolo = simboloPieza;
            jugador = numeroJugador;
        }

        public char GetSimbolo()
        {
            return simbolo;
        }

        public int GetJugador()
        {
            return jugador;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public abstract bool MovimientoValido(
            int fo,
            int co,
            int fd,
            int cd,
            Pieza[,] tablero
        );
    }
}