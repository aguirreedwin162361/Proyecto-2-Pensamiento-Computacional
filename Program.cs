using System;

namespace JuegoTablero
{
    class Program
    {
        static void Main(string[] args)
        {
            Login login = new Login();

            login.IniciarSesion();

            Juego juego = new Juego();

            juego.MenuPrincipal();
        }
    }
}
