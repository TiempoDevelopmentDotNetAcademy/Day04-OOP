using System;

namespace OOP_Modifiers
{
    public class SocketConnection {

        public int public_id;
        protected int protected_id;
        internal int internal_id;
        private int private_id;

        protected internal int protected_internal_id;

        private protected int private_protected_id;
        

        public SocketConnection(){
            Console.WriteLine("Socket Connection initialized");
        }

        public virtual bool Open(string url, int port, int type) {
            Console.WriteLine("Connecting with {0}:{1}", url, port);
            return true;
        }

        public virtual int Send(string buffer) {
            Console.WriteLine("Sending Buffer {0}", buffer);
            return buffer.Length;
        }

        public virtual string Recv(int length) {
            Console.WriteLine("Received 12 bytes");
            return "Hello World!";
        }

        public virtual bool Close() {
            Console.WriteLine("SocketConnection close.");
            return true;
        }
    }

    public class TCPConnection : SocketConnection {

        public int Type = 1;

        public TCPConnection(): base() {
            Console.WriteLine("TCPConnection initialized");
        }

        public bool Open(string url, int port) {
            base.Open(url, port, Type);
            Console.WriteLine("Access to Public properties: {0}", this.public_id);
            Console.WriteLine("Access to Protected properties: {0}", this.protected_id);
            //Console.WriteLine("Cannot access to Private properties: {0}", this.private_id);
            Console.WriteLine("Access to Internal: {0}", this.internal_id);
            Console.WriteLine("Access to Private Protected: {0}", this.private_protected_id);
            Console.WriteLine("Access to Protected Internal: {0}", this.protected_internal_id);
            return true;
        }

        // override vs new
        public override bool Close() {
            Console.WriteLine("TCPConnection Close");
            return true;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            SocketConnection s = new SocketConnection();
            TCPConnection tcp = new TCPConnection();
            SocketConnection tcps = new TCPConnection();
            Console.WriteLine("Access Public property {0}", s.public_id);
            Console.WriteLine("Access Protected from the same assembly {0}", s.internal_id);
            Console.WriteLine("Access Protected Internal from the same assembly {0}", s.protected_internal_id);
            //Cannot access it because we don't inherit from it.
            //Console.WriteLine("s {0}", s.private_protected_id);
            
            
            tcp.Close();
            s.Close();
            tcps.Close();
            
        }
    }
}
