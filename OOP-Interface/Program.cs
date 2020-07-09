using System;

namespace OOP_Interface
{
    public interface IConnection
    {
        int Open();

        void Close();
    }

    public class TCPConnection : IConnection {

        public int Open() {
            Console.WriteLine("Open");
            return 0;
        }

        public int Write(string buffer) {
            Console.WriteLine("Sending string buffer to stream.");
            return buffer.Length;
        }

        public int Write(byte buffer) {
            Console.WriteLine("Sending bytes buffer to stream.");
            return buffer.ToString().Length;
        }

        public void Close() {
            Console.WriteLine("Close");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TCPConnection connection;
            connection = new TCPConnection();
            connection.Open();            
            connection.Close();
        }
    }
}
