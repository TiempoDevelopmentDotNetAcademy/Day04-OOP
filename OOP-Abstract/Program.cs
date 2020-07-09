using System;

namespace OOP_Abstract
{

    public abstract class GameConnection {

        public int Server_Connect() {
            Console.WriteLine("Connection to server");
            return 0;
        }
        public abstract int Play();

        public virtual int Server_Disconnect() {
            Console.WriteLine("Diconnecting from Server.");
            return 0;
        }
    }

    public class Game : GameConnection {
        
        public override int Play() {
            Console.WriteLine("Playing Tic Tac Toe");
            return 0;
        }

        public override int Server_Disconnect() {
            base.Server_Disconnect();
             Console.WriteLine("Game disconnect.");
             return 0;
        }

        /*public new int Server_Disconnect() {
            Console.WriteLine("Game Server Disconnect");
            return 0;
        }*/
    }

    class Program
    {
        static void Main(string[] args)
        {
            Game tictactoe;
            tictactoe = new Game();

            tictactoe.Server_Connect();
            tictactoe.Play();
            tictactoe.Server_Disconnect();
        }
    }
}
