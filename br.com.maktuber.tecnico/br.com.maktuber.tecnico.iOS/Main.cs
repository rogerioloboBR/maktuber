using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace br.com.maktuber.tecnico.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
#pragma warning disable XI0003 // Notifica você ao usar uma API da Apple preterida, obsoleta ou indisponível
            UIApplication.Main(args, null, "AppDelegate");
#pragma warning restore XI0003 // Notifica você ao usar uma API da Apple preterida, obsoleta ou indisponível
        }
    }
}
