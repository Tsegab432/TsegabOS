using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using System.Threading;
using System.ComponentModel.Design;
using TsegabOS.Apps;
using System.IO;
using Cosmos.System.FileSystem.VFS;
using System.Security.Cryptography.X509Certificates;
using Cosmos.System.FileSystem;

namespace DeveloperOS
{
    public class Kernel : Sys.Kernel
    {
        public string Name;
        public string Command;
        public string Output;
        public int Numbers;

        protected override void BeforeRun()
        {
            Thread.Sleep(3000);
            Console.Clear();

            // Display loading animation
            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Loading the OS please wait... " + i + "/10");

                // Simulate animation by waiting for a short time
                System.Threading.Thread.Sleep(500);
            }
            Console.Clear();
            Console.WriteLine("Welcome to the Developer OS (Shell version)");
            Console.Write("Enter your name here: ");
            Name = Console.ReadLine();
            Console.Clear();
            if (Name == "")
            {
                Name = "User";
            }
            Console.WriteLine("Hello and Welcome to Developer Shell OS " + Name);

            VFSManager.RegisterVFS(new Sys.FileSystem.CosmosVFS());
        }


        protected override void Run()
        {

            Console.Write(">");
            Command = Console.ReadLine();
            if (Command.ToLower().StartsWith("color"))
            {
                Dictionary<string, ConsoleColor> colorMappings = new Dictionary<string, ConsoleColor>
                    {
                        { "black", ConsoleColor.Black },
                        { "red", ConsoleColor.Red },
                        { "green", ConsoleColor.Green },
                        { "yellow", ConsoleColor.Yellow },
                        { "blue", ConsoleColor.Blue },
                        { "magenta", ConsoleColor.Magenta },
                        { "cyan", ConsoleColor.Cyan },
                        { "white", ConsoleColor.White }
                    };

                string[] commandParts = Command.Split(' ');

                if (commandParts.Length >= 2 && colorMappings.TryGetValue(commandParts[1].ToLower(), out ConsoleColor chosenColor))
                {
                    Console.ForegroundColor = chosenColor;
                }
            }
            else {
                if (Command.ToLower().StartsWith("output "))
                {
                    // Get the text after "echo " and display it
                    string echoText = Command.Substring(7);
                    Console.WriteLine(echoText);
                }
                else
                {
                    // Handle other commands or echo back unrecognized input
                    switch (Command.ToLower())
                    {
                        case "test":
                            Console.WriteLine("Test command executed!");
                            break;
                        //Alien
                        case "alien":
                            Console.WriteLine(@"
 .     .       .  .   . .   .   . .    +  .
  .     .  :     .    .. :. .___---------___.
       .  .   .    .  :.:. _"".^ .^ ^.  '.. :""-_. .
    .  :       .  .  .:../:            . .^  :.:\.
        .   . :: +. :.:/: .   .    .        . . .:\.
 .  :    .     . _ :::/:               .  ^ .  . .:\
  .. . .   . - : :.:./.                        .  .:\
  .      .     . :..|:                    .  .  ^. .:|
    .       . : : ..||        .                . . !:|
  .     . . . ::. ::\(                           . :)/
 .   .     : . : .:.|. ######              .#######::|
  :.. .  :-  : .:  ::|.#######           ..########:|
 .  .  .  ..  .  .. :\ ########          :######## :/
  .        .+ :: : -.:\ ########       . ########.:/
    .  .+   . . . . :.:\. #######       #######..:/
      :: . . . . ::.:..:.\           .   .   ..:/
   .   .   .  .. :  -::::.\.       | |     . .:/
     .  :  .  .  .-:."":.::.\             ..:/
 .      -.   . . . .: .:::.:.\.           .:/
.   .   .  :      : ....::_:..:\   ___.  :/
   .   .  .   .:. .. .  .: :.:.:\       :/
     +   .   .   : . ::. :.:. .:.|\  .:/|
     .         +   .  .  ...:: ..|  --.:|
.      . . .   .  .  . ... :..:..""(  ..)"")
 .   .       .      :  .   .: ::/  .  .::\
        ");
                            break;
                        //Clears the console
                        case "clear":
                            Console.Clear();
                            break;
                        //Cow
                        case "cow":
                            Console.WriteLine(@"
            /)  (\
       .-._((,~~.))_.-,
        `=.   99   ,='
          / ,o~~o. \
         { { .__. } }
          ) `~~~\' (
         /`-._  _\.-\
        /         )  \
       ,-X        #   X-.
     /   \          /   \
    (     )| |  | |(     )
     \   / | |  | | \   /
      \_(.-( )--( )-.)_/
");
                            break;

                        case "help":
                            Console.WriteLine("test - Execute the test command.");
                            Console.WriteLine("alien - Display an ASCII art alien.");
                            Console.WriteLine("cow - Display an ASCII art cow.");
                            Console.WriteLine("clear - Clear the console.");
                            Console.WriteLine("help - Display this help message.");
                            Console.WriteLine("whoami - Tell your username");
                            Console.WriteLine("output - prints your text");
                            Console.WriteLine("change - changes your user name");
                            Console.WriteLine("shutdown - Shutdowns the computer");
                            Console.WriteLine("restrart - Reboots the computer");
                            Console.WriteLine("calculator - opens a shell based calculator");
                            Console.WriteLine("applist - you can see the app list");
                            Console.WriteLine("file - opens the fileviewer");
                            Console.WriteLine("ascii - changes inputed text to a ascii art");
                            break;

                        case "whoami":
                            Console.WriteLine(Name);
                            break;

                        case "change":
                            Console.WriteLine(@"              
               :#%%%%%%#:               
             .*%%%%%%%%%%*.             
            .%%%%%%%%%%%%%%:            
            #%%%%%%%%%%%%%%#            
           +%%%%%%%%%%%%%%%%*           
          :%%%%%%%%%%%%%%%%%%.          
          =%%%%%%%%%%%%%%%%%%-          
          *%%%%%%%%%%%%%%%%%%*          
          #%%%%%%%%%%%%%%%%%%#          
          %%%%%%%%%%%%%%%%%%%%          
          #%%%%%%%%%%%%%%%%%%#          
          *%%%%%%%%%%%%%%%%%%*          
          =%%%%%%%%%%%%%%%%%%=          
          :%%%%%%%%%%%%%%%%%%.          
           *%%%%%%%%%%%%%%%%*           
            #%%%%%%%%%%%%%%#            
            .%%%%%%%%%%%%%%:            
             .*%%%%%%%%%%*.             
               :%%%%%%%%:               
             =+: :-==-: :++.            
           .#%%%#=...:=#%%%#.           
          :#%%%%%%%%%%%%%%%%%-          
         :%%%%%%%%%%%%%%%%%%%%:         
         #%%%%%%%%%%%%%%%%%%%%#.        
        =%%%%%%%%%%%%%%%%%%%%%%=        
        %%%%%%%%%%%%%%%%%%%%%%%%        
       :%%%%%%%%%%%%%%%%%%%%%%%%:       
       -%%%%%%%%%%%%%%%%%%%%%%%%-       
       -%%%%%%%%%%%%%%%%%%%%%%%%=       
       =%%%%%%%%%%%%%%%%%%%%%%%%=       
       -%%%%%%%%%%%%%%%%%%%%%%%%-       
        #%%%%%%%%%%%%%%%%%%%%%%#.       
         =#%%%%%%%%%%%%%%%%%%#+         
          .:+%%%%%%%%%%%%@%+:           
              .:--====--:.                  
                                                  
                                       ");
                            Console.Write("Wrte your new name here: ");
                            if (Name == "")
                            {
                                Name = "User";
                            }
                            Name = Console.ReadLine();
                            break;

                        case "calculator":
                            RunCalculator();
                            break;

                        case "shutdown":
                            Cosmos.System.Power.Shutdown();
                            break;

                        case "restart":
                            Cosmos.System.Power.Reboot();
                            break;

                        case "color":
                            Console.WriteLine("If you don't have any idea write the command (colorlist) and you will see the color lists");
                            break;

                        case "colorlist":
                            Console.WriteLine("Red");
                            Console.WriteLine("Green");
                            Console.WriteLine("Blue");
                            Console.WriteLine("Yellow");
                            Console.WriteLine("Magenta");
                            Console.WriteLine("Cyan");
                            break;
                        //apps
                        case "ascii":
                            Ascii.Test();
                            break;
                        case "guess game":
                            Guess_Game.Game();
                            break;
                        //end of apps


                        //file
                        case "file":
                            Program.Main();
                            break;

                        //file end
                        case "enchanted forest":
                            game1.Main();
                            break;
                        

                        case "applist":
                            Console.WriteLine(@"guess game - Play a game by guessing a number 
ascii - this allows you to see A-Z letters in 3-D Ascii art
Notepad - this allows you to write and save your doucments that you written
calculator - this allows you to add, subtract, multiply and divide numbers");
                            break;
                        case "timer":
                            Time.Time1();
                            break;
                            

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Unknown command. Type 'help' for a list of available commands.");
                            Console.ResetColor();
                            break;
                    }
                    

                    //Calculator
                    static void RunCalculator()
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("If the Calculator got any overflow it will display 0");
                        Console.ResetColor();

                        int result = 0;
                        bool firstInput = true;

                        while (true)
                        {
                            Console.Write("Enter a number (or 'finish' to calculate): ");
                            string input = Console.ReadLine();

                            if (input.ToLower() == "finish")
                            {
                                if (result == int.MaxValue)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Overflow");
                                    Console.ResetColor();
                                }
                                else if (!firstInput)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"Final Result: {result}");
                                    Console.ResetColor();
                                }
                                else
                                {
                                    Console.WriteLine("No numbers entered.");
                                }

                                break;
                            }

                            if (int.TryParse(input, out int number))
                            {
                                if (firstInput)
                                {
                                    result = number;
                                    firstInput = false;
                                }
                                else
                                {
                                    Console.Write("Select an operation (+, -, *, /): ");
                                    char operation = char.Parse(Console.ReadLine());

                                    switch (operation)
                                    {
                                        case '+':
                                            result += number;
                                            break;
                                        case '-':
                                            result -= number;
                                            break;
                                        case '*':
                                            result *= number;
                                            break;
                                        case '/':
                                            if (number != 0)
                                            {
                                                result /= number;
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("Division by zero is not allowed.");
                                                Console.ResetColor();
                                            }
                                            break;
                                        default:
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Invalid operation.");
                                            Console.ResetColor();
                                            return;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid number.");
                            }
                        }
                    }
                }
            }

        }
    }
}