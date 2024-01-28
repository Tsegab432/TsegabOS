using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TsegabOS.Apps
{
    public class Guess_Game
    {
        public static string guess;
        public static string option;

        static Random random = new Random();

        int returnValue = random.Next(1, 100);
        int Guess = 0;


        public static void Game()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"  
    //   ) )                                                                 
   //        _    __     ___      ___      ___            
  //  ____  //   / / //___) ) ((   ) ) ((   ) )     
 //    / / //   / / //         \ \      \ \            
((____/ / ((___( ( ((____   //   ) ) //   ) ) ");
            Console.ResetColor();
            Console.WriteLine(@"1. Easy
2. Intermidiate
3. Advance
4. Master
5. Legend");
            while (true)
            {
                Console.Write("Select your difficulty from 1 - 5: ");
                option = Console.ReadLine();

                //Option 1

                if (option == "1")
                {
                    Console.WriteLine("Guess a Number from 1 - 10: ");
                    guess = Console.ReadLine();

                    if (int.TryParse(guess, out int userGuess))
                    {
                        int randomGuess = random.Next(0, 11);
                        Console.WriteLine($"Your guess: {userGuess}");
                        Console.WriteLine($"Random guess: {randomGuess}");

                        if (userGuess == randomGuess)
                        {
                            Console.WriteLine(@"         
         -''--.
       _`>   `\.-'<
    _.'     _     '._
  .'   _.='   '=._   '.
  >_   / /_\ /_\ \   _<
    / (  \o/\\o/  ) \
    >._\ .-,_)-. /_.<
jgs     /__/ \__\ 
          '---'     E=mc^2  ");
                            Console.WriteLine("eeh! not impresive but you got the correct number");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, your guess is incorrect.");
                        }
                    }
                }
                //option 2

                if (option == "2")
                {
                    Console.WriteLine("Guess a Number from 1 - 50: ");
                    guess = Console.ReadLine();

                    if (int.TryParse(guess, out int userGuess))
                    {
                        int randomGuess = random.Next(0, 51);
                        Console.WriteLine($"Your guess: {userGuess}");
                        Console.WriteLine($"Random guess: {randomGuess}");

                        if (userGuess == randomGuess)
                        {
                            Console.WriteLine("You got the correct number");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, your guess is incorrect.");
                        }
                    }
                }
                //option 3

                if (option == "3")
                {
                    Console.WriteLine("Guess a Number from 1 - 100: ");
                    guess = Console.ReadLine();

                    if (int.TryParse(guess, out int userGuess))
                    {
                        int randomGuess = random.Next(0, 101);
                        Console.WriteLine($"Your guess: {userGuess}");
                        Console.WriteLine($"Random guess: {randomGuess}");

                        if (userGuess == randomGuess)
                        {
                            Console.WriteLine("Nice you got the right number");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, your guess is incorrect.");
                        }
                    }
                }
                //option 4

                if (option == "4")
                {
                    Console.WriteLine("Guess a Number from 1 - 1000: ");
                    guess = Console.ReadLine();

                    if (int.TryParse(guess, out int userGuess))
                    {
                        int randomGuess = random.Next(0, 1001);
                        Console.WriteLine($"Your guess: {userGuess}");
                        Console.WriteLine($"Random guess: {randomGuess}");

                        if (userGuess == randomGuess)
                        {
                            Console.WriteLine("Wow! Not bad keep it up");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, your guess is incorrect.");
                        }
                    }
                }
                //option 5
                if (option == "5")
                {
                    Console.WriteLine("Guess a Number from 1 - 1,000,000: ");
                    guess = Console.ReadLine();

                    if (int.TryParse(guess, out int userGuess))
                    {
                        int randomGuess = random.Next(0, 1000001);
                        Console.WriteLine($"Your guess: {userGuess}");
                        Console.WriteLine($"Random guess: {randomGuess}");

                        if (userGuess == randomGuess)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(@"                    .+~                :xx++::
                   :`. -          .!!X!~""?!`~!~!. :-:.
                  {             .!!!H"":.~ ::+!~~!!!~ `%X.
                  '             ~~!M!!>!!X?!!!!!!!!!!...!~.
                              {!:!MM!~:XM!!!!!!.:!..~ !.  `{
                  {: `   :~ .:{~!!M!XXHM!!!X!XXHtMMHHHX!  ~ ~
                ~~~~{' ~!!!:!!!!!XM!!M!!!XHMMMRMSXXX!!!!!!:  {`
                  `{  {::!!!!!X!X?M!!M!!XMMMMXXMMMM??!!!!!?!:~{
               : '~~~{!!!XMMH!!XMXMXHHXXXXM!!!!MMMMSXXXX!!!!!!!~
            :    ::`~!!!MMMMXXXtMMMMMMMMMMMHX!!!!!!HMMMMMX!!!!!: ~
               '~:~!!!!!MMMMMMMMMMMMMMMMMMMMMMXXX!!!M??MMMM!!X!!i:
               {~{!!!!!XMMMMMMMMMMMM8M8MMMMM8MMMMMXX!!!!!!!!X!?t?!:
               ~:~~!!!!?MMMMMM@M@RMRRR$@@MMRMRMMMMMMXSX!!!XMMMX{?X!
             :XX {!!XHMMMM88MM88BR$M$$$$8@8RN88MMMMMMMMHXX?MMMMMX!!!
           .:X! {XMSM8M@@$$$$$$$$$$$$$$$$$$$B8R$8MMMMMMMMMMMMMMMMX!X
          :!?! !?XMMMMM8$$$$8$$$$$$$$$$$$$$BBR$$MMM@MMMMMMMMMMMMMM!!X
        ~{!!~ {!!XMMMB$$$$$$$$$$$$$$$$$$$$$$$$MMR$8MR$MMMMMMMMMMMMM!?!:
        :~~~ !:X!XMM8$$$$$$$$$$$$$$$$$$$$$$$RR$$MMMMR8NMMMMMMMMMMMMM{!`-
    ~:{!:~`~':!:HMM8N$$$$$$$$$$$$$$$$$$$$$$$$$8MRMM8R$MRMMMMMMMMRMMMX!
  !X!``~~   :~XM?SMM$B$$$$$$$$$$$$$$$$$$$$$$BR$$MMM$@R$M$MMMMMM$MMMMX?L
 X~.      : `!!!MM#$RR$$$$$$$$$$$$$$$$$R$$$$$R$M$MMRRRM8MMMMMMM$$MMMM!?:
 ! ~ {~  !! !!~`` :!!MR$$$$$$$$$$RMM!?!??RR?#R8$M$MMMRM$RMMMM8MM$MMM!M!:>
: ' >!~ '!!  !   .!XMM8$$$$$@$$$R888HMM!!XXHWX$8$RM$MR5$8MMMMR$$@MMM!!!{ ~
!  ' !  ~!! :!:XXHXMMMR$$$$$$$$$$$$$$$$8$$$$8$$$MMR$M$$$MMMMMM$$$MMM!!!!
 ~{!!!  !!! !!HMMMMMMMM$$$$$$$$$$$$$$$$$$$$$$$$$$MMM$M$$MM8MMMR$$MMXX!!!!/:`
  ~!!!  !!! !XMMMMMMMMMMR$$$$$$$$$$$$R$RRR$$$$$$$MMMM$RM$MM8MM$$$M8MMMX!!!!:
  !~ ~  !!~ XMMM%!!!XMMX?M$$$$$$$$B$MMSXXXH?MR$$8MMMM$$@$8$M$B$$$$B$MMMX!!!!
  ~!    !! 'XMM?~~!!!MMMX!M$$$$$$MRMMM?!%MMMH!R$MMMMMM$$$MM$8$$$$$$MR@M!!!!!
  {>    !!  !Mf x@#""~!t?M~!$$$$$RMMM?Xb@!~`??MS$M@MMM@RMRMMM$$$$$$RMMMMM!!!!
  !    '!~ {!!:!?M   !@!M{XM$$R5M$8MMM$! -XXXMMRMBMMM$RMMM@$R$BR$MMMMX??!X!!
  !    '!  !!X!!!?::xH!HM:MM$RM8M$RHMMMX...XMMMMM$RMMRRMMMMMMM8MMMMMMMMX!!X!
  !     ~  !!?:::!!!MXMR~!MMMRMM8MMMMMS!!M?XXMMMMM$$M$M$RMMMM8$RMMMMMMMM%X!!
  ~     ~  !~~X!!XHMMM?~ XM$MMMMRMMMMMM@MMMMMMMMMM$8@MMMMMMMMRMMMMM?!MMM%HX!
           !!!!XSMMXXMM .MMMMMMMM$$$BB8MMM@MMMMMMMR$RMMMMMMMMMMMMMMMXX!?H!XX
           XHXMMMMMMMM!.XMMMMMMMMMR$$$8M$$$$$M@88MMMMMMMMMMMMMMM!XMMMXX!!!XM
      ~   {!MMMMMMMMRM:XMMMMMMMMMM8R$$$$$$$$$$$$$$$NMMMMMMMM?!MM!M8MXX!!/t!M
      '   ~HMMMMMMMMM~!MM8@8MMM!MM$$8$$$$$$$$$$$$$$8MMMMMMM!!XMMMM$8MR!MX!MM
          'MMMMMMMMMM'MM$$$$$MMXMXM$$$$$$$$$$$$$$$$RMMMMMMM!!MMM$$$$MMMMM{!M
          'MMMMMMMMM!'MM$$$$$RMMMMMM$$$$$$$$$$$$$$$MMM!MMMX!!MM$$$$$M$$M$M!M
           !MMMMMM$M! !MR$$$RMM8$8MXM8$$$$$$$$$$$$NMMM!MMM!!!?MRR$$RXM$$MR!M
           !M?XMM$$M.{ !MMMMMMSUSRMXM$8R$$$$$$$$$$#$MM!MMM!X!t8$M$MMMHMRMMX$
    ,-,   '!!!MM$RMSMX:.?!XMHRR$RM88$$$8M$$$$$R$$$$8MM!MMXMH!M$$RMMMMRNMMX!$
   -'`    '!!!MMMMMMMMMM8$RMM8MBMRRMR8RMMM$$$$8$8$$$MMXMMMMM!MR$MM!M?MMMMMM$
          'XX!MMMMMMM@RMM$MM@$$BM$$$M8MMMMR$$$$@$$$$MM!MMMMXX$MRM!XH!!??XMMM
          `!!!M?MHMMM$RMMMR@$$$$MR@MMMM8MMMM$$$$$$$WMM!MMMM!M$RMM!!.MM!%M?~!
           !!!!!!MMMMBMM$$RRMMMR8MMMMMRMMMMM8$$$$$$$MM?MMMM!f#RM~    `~!!!~!
           ~!!HX!!~!?MM?MMM??MM?MMMMMMMMMRMMMM$$$$$MMM!MMMM!!
           '!!!MX!:`~~`~~!~~!!!!XM!!!?!?MMMM8$$$$$MMMMXMMM!!
            !!~M@MX.. {!!X!!!!XHMHX!!``!XMMMB$MM$$B$M!MMM!!
            !!!?MRMM!:!XHMHMMMMMMMM!  X!SMMX$$MM$$$RMXMMM~
             !M!MMMM>!XMMMMMMMMXMM!!:!MM$MMMBRM$$$$8MMMM~
             `?H!M$R>'MMMM?MMM!MM6!X!XM$$$MM$MM$$$$MX$f
              `MXM$8X MMMMMMM!!MM!!!!XM$$$MM$MM$$$RX@""
               ~M?$MM !MMMMXM!!MM!!!XMMM$$$8$XM$$RM!`
                !XMMM !MMMMXX!XM!!!HMMMM$$$$RH$$M!~
                'M?MM `?MMXMM!XM!XMMMMM$$$$$RM$$#
                 `>MMk ~MMHM!XM!XMMM$$$$$$BRM$M""
                  ~`?M. !M?MXM!X$$@M$$$$$$RMM#
                    `!M  !!MM!X8$$$RM$$$$MM#`
                      !% `~~~X8$$$$8M$$RR#`
                       !!x:xH$$$$$$$R$R*`
                        ~!?MMMMRRRM@M#`       
                         `~???MMM?M""`
                             ``~~");

                            Console.WriteLine("What! This is not possible! How!?!?!?!");
                            Console.WriteLine("Wow reach us for a prize on devtsegab@gmail.com");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Sorry, your guess is incorrect.");
                            Console.ResetColor();
                        }
                    }
                }
            }
        }
    }
}
