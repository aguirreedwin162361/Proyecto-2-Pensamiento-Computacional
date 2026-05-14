namespace JuegoTablero
{
    class Jugador
    {
        private string nombre;
        private int numero;
        private int puntos;

        public Jugador(string nombreJugador, int numeroJugador)
        {
            nombre = nombreJugador;
            numero = numeroJugador;

            puntos = 0;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public int GetNumero()
        {
            return numero;
        }

        public int GetPuntos()
        {
            return puntos;
        }

        public void AgregarPuntos(
            int puntosGanados
        )
        {
            puntos += puntosGanados;
        }
    }
}