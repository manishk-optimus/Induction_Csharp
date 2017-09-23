using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Mobile
    {
        public string model { get; set; }
        public string manufacturer { get; set; }
        public string IMEI { get; set; } 

        public void call()
        {
            Console.WriteLine("calling");
        }
        public void recieve()
        {
            Console.WriteLine("recieving");
        }
    }
    class Multimedia:Mobile
    {
        public void camera()
        {
            Console.WriteLine("clicking photos");
        }
        public void messaging()
        {
            Console.WriteLine("Messaging");
           
        }
        public void video_call()
        {
            Console.WriteLine("video calling");
        }
    }
    class Samsung : Multimedia
    {
        public void fingerprint()
        {
            Console.WriteLine("scanning");
        }
        public void screentouch()
        {
            Console.WriteLine("touch_screen");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Samsung S3 = new Samsung();
            S3.messaging();
            S3.recieve();
            S3.call();
            S3.fingerprint();
            Console.ReadLine();

        }
        
    }


}
