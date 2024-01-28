using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using System.Threading;
using System.ComponentModel.Design;
using Cosmos.System.Graphics;
using System.Drawing;
using Cosmos.System.FileSystem;
using TsegabOS;
using System.Linq;

namespace TsegabOS.Apps
{
    public class Ascii
    {
        public static string Command1;
        public static void Test()
        {

            //Welcome
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
 __      __         .__                                    
/  \    /  \  ____  |  |    ____   ____    _____    ____   
\   \/\/   /_/ __ \ |  |  _/ ___\ /  _ \  /     \ _/ __ \  
 \        / \  ___/ |  |__\  \___(  <_> )|  Y Y  \\  ___/  
  \__/\  /   \___  >|____/ \___  >\____/ |__|_|  / \___  > 
       \/        \/            \/              \/      \/  
                                                           ");
            Console.ResetColor();
            //end of the welcome sign
            while (true)
            {
                Console.Write("Ascii>");
                Command1 = Console.ReadLine();
                if (Command1 == "a")
                {
                    Console.WriteLine(@"
 ________     
|\   __  \    
\ \  \|\  \   
 \ \   __  \  
  \ \  \ \  \ 
   \ \__\ \__\
    \|__|\|__|
              
              
");
                }
                else if (Command1 == "b")
                {
                    Console.WriteLine(@"
 ________     
|\   __  \    
\ \  \|\ /_   
 \ \   __  \  
  \ \  \|\  \ 
   \ \_______\
    \|_______|
                 
              
");
                }
                else if (Command1 == "c")
                    {
                        Console.WriteLine(@"
 ________     
|\   ____\    
\ \  \___|    
 \ \  \       
  \ \  \____  
   \ \_______\
    \|_______| 
              
");
                    }
                else if (Command1 == "d")
                {
                    Console.WriteLine(@"     
      ,---, 
    ,---.'| 
    |   | : 
    |   | | 
  ,--.__| | 
 /   ,'   | 
.   '  /  | 
'   ; |:  | 
|   | '/  ' 
|   :    :| 
 \   \  /   
  `----'    
            
");
                }
            }
        }
    }
}



