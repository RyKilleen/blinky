using System;
using System.Net;
using System.Net.Sockets;

using System.IO;
using System.Text;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

namespace BlinkyNetduino
{
    public class Program
    {
        public static void Main()
        {

            OutputPort led = new OutputPort(Pins.ONBOARD_LED, false);
            InputPort button = new InputPort(Pins.ONBOARD_SW1, false, Port.ResistorMode.Disabled);


            bool buttonState = false;





            while (true)
            {
                buttonState = button.Read();

                if (buttonState == true)
                {

                    string URI = "http://RYANDESKTOP/blinky/home/push";
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URI);
                    request.Method = "GET";
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                    while (buttonState == true)
                    {


                        buttonState = button.Read();


                    }

                     URI = "http://RYANDESKTOP/blinky/home/release";
                    request = (HttpWebRequest)WebRequest.Create(URI);
                    request.Method = "GET";
                    response = (HttpWebResponse)request.GetResponse();



                }
            }
        }

    }
}
