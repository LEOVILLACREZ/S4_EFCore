using S4_EFCore.CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace S4_EFCore.CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            // Contiene todo el trabajo
            using var context = new MundialDBContext();

            // ------------------INSERTAR ---------------------
            // ------------------------------------------------

            // METODO PARA AGREGAR INDIVUAL --------------------------------

            //var player1 = new Player();
            //player1.FullName = "Cristiano Ronaldo";
            //player1.Dorsal = 7;

            //// Context, Nombre de clase - tabla. Add(objeto)
            //context.Player.Add(player1);
            //context.SaveChanges();



            // METODO PARA AGREGAR EN GRUPO -------------------------------

            //var player2 = new Player();
            //player2.FullName = "Leonel Messi";
            //player2.Dorsal = 10;

            //var player3 = new Player();
            //player3.FullName = "Paolo Guerrero";
            //player3.Dorsal = 9;

            //var players = new List<Player>();
            //players.Add(player2);
            //players.Add(player3);

            //context.Player.AddRange(players);
            //context.SaveChanges();


            //  --------------------------------------- LINQ EXPRESSION ----------------------------------
            // -------------------------------------------------------------------------------------------


            // ----------------- CONSULTAR --------------------
            // ------------------------------------------------


            //var searchPlayer = (from p in context.Player
            //                    where p.Dorsal == 9
            //                    select p).FirstOrDefault();

            //Console.WriteLine("Jugador Encontrado: " 
            //                    + searchPlayer.FullName 
            //                    + " Dorsal: " + searchPlayer.Dorsal);


            // ----------------- REMOVER ----------------------
            // ------------------------------------------------

            //context.Player.Remove(searchPlayer);
            //context.SaveChanges();
            //Console.WriteLine("Jugador Eliminado: " + searchPlayer.FullName);




            // ----------------- UPDATE -----------------------
            // ------------------------------------------------

            //var searchPlayer = (from p in context.Player
            //                    where p.Dorsal == 10
            //                    select p).FirstOrDefault();

            //searchPlayer.FullName = "Jefferson Farfan";
            //context.SaveChanges();



            // ----------------- BUSQUEDA MASIVA -----------------------
            // ---------------------------------------------------------

            var searchPlayer = (from p in context.Player
                                where p.Dorsal == 10
                                select p).ToList();

            foreach (var item in searchPlayer)
            {
                Console.WriteLine("Jugador Encontrado: "
                                   + item.FullName
                                   + " Dorsal: " + item.Dorsal);
            }




            //  --------------------------------------- LAMBDA EXPRESSIONS--------------------------------
            // -------------------------------------------------------------------------------------------

            var searchListPlayerLambda = context.Player.Where(x => x.Dorsal == 7).ToList();


            Console.WriteLine("Hello World!");
        }
    }
}
