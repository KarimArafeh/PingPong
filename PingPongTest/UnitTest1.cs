using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PingPong;


namespace PingPongTest
{
    [TestClass]
    public class UnitTest1
    {
        private List<Jugador> listaJugadors = new List<Jugador>();
        private List<Partidas> listaPartidas = new List<Partidas>();

        [TestMethod]
        public void TestlistaJugadors()
        {

            Jugador jug1 = new Jugador();
            jug1.Nom = "NomJugador1";
            jug1.Apellido = "ApellidoJugador1";

            listaJugadors.Add(jug1);

            Jugador jug2 = new Jugador();
            jug2.Nom = "NomJugador2";
            jug2.Apellido = "ApellidoJugador2";

            listaJugadors.Add(jug2);

            Jugador jug3 = new Jugador();
            jug3.Nom = "NomJugador3";
            jug3.Apellido = "ApellidoJugador3";

            listaJugadors.Add(jug3);

            Assert.IsNotNull(listaJugadors);
        }

        [TestMethod]
        public void TestlistaPartidos()
        {
            Assert.AreEqual<int>(0, listaJugadors.Count);

            for (int i = 0; i < listaJugadors.Count; i++)
            {
                for (int j = i + 1; j < listaJugadors.Count; j++)
                {
                    Partidas par = new Partidas();
                    par.NomJugador1 = listaJugadors[i].Nom;
                    par.ApellidoJugador1 = listaJugadors[i].Apellido;
                    par.NomJugador2 = listaJugadors[j].Nom;
                    par.ApellidoJugador2 = listaJugadors[j].Apellido;
                    listaPartidas.Add(par);
                }
            }

            Assert.IsNotNull(listaPartidas);
        }
    }
}
