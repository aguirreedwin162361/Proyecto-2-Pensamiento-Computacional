using System;

namespace JuegoTablero
{
    class Login
    {
        private string usuario = "Pensamiento";
        private string Contraseña = "Computacional123!";

        public void IniciarSesion()
        {
            string leerusuario;
            string leercontraseña;

            do
            {
                Console.Clear();

                Console.Write("Usuario: ");
                leerusuario = Console.ReadLine();

                Console.Write("Contraseña: ");
                leercontraseña = Console.ReadLine();

                if (leerusuario != usuario || leercontraseña != Contraseña)
                {
                    Console.WriteLine(
                        "Datos incorrectos"
                    );

                    Console.ReadKey();
                }

            } while (
                leerusuario != usuario ||
                leercontraseña != Contraseña
            );

            Console.WriteLine(
                "Acceso permitido"
            );

            Console.ReadKey();
        }
    }
}