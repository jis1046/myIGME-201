using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Unit1Q4
{
    //Josh Samuel
    //Unit test 1 Question 4
    //Making code application for 3question.exe
    //Issue: could not figure out to stop timer for one time
    internal class Program
    {
        static void Main(string[] args)
        {
            //Set up timer for question 1
            void HandleTimer1()
            {
                Console.WriteLine("Time's up");
                Console.WriteLine("The answer is: black");
                Console.WriteLine("Play again?");
            }

            //Set up timer for question 2
            void HandleTimer2()
            {
                Console.WriteLine("Time's up");
                Console.WriteLine("The answer is: 42");
                Console.WriteLine("Play again?");
            }

            //Set up timer for question 3
            void HandleTimer3()
            {
                Console.WriteLine("Time's up");
                Console.WriteLine("The answer is: What do you mean? African or European swallow?");
                Console.WriteLine("Play again?");
            }

            //Set while to keep going 
            bool read = true;
            while (read) {
                //use label "repeat" for computer to tell go where
                repeat:
                Console.Write("Choose your question (1-3): ");
                string respond = Console.ReadLine();
                if(respond == "1")
                {              
                    Console.WriteLine("You have 5 seconds to answer the following question:\n" +
                        "What is your favorite color?");
                    //Set 5 second timer
                    Timer timer = new Timer(5000);
                    timer.Elapsed += (sneder, e) => HandleTimer1();
                    timer.Start();
                    respond = Console.ReadLine();
                    //tells the user that time is up
                    timer.Dispose();   
                    timer.Stop();

                    //user respond before timer
                    //Labels to tell the computer where to go
                    if(respond == "black") 
                    {
                        goto a1;
                    }
                    else if(respond == "yes" || respond == "no")
                    {
                        goto retry1;
                    }
                    else
                    {
                        goto a1;
                    }
                    retry1:
                    while (read)
                    {
                    retry:
                        Console.WriteLine("Play again?");
                        respond = Console.ReadLine();
                        if (respond == "yes")
                        {
                            goto repeat;
                        }
                        else if (respond == "no")
                        {
                            //tells the computer to stop the program
                            Environment.Exit(0);
                        }
                        else
                        {
                            goto retry;
                        }
                    }

                    a1:
                    if (respond != "black")
                    {
                        Console.WriteLine("Wrong! The answer is: black");
                    }
                    else
                    {
                        Console.WriteLine("Well done!");
                    }
                  
                    while (read)
                    {
                        retry:
                        Console.WriteLine("Play again?");
                        respond = Console.ReadLine();
                        if (respond == "yes")
                        {
                            goto repeat;
                        }
                        else if (respond == "no") 
                        {   
                            //tells the computer to stop the program
                            Environment.Exit(0);
                        }
                        else
                        {
                            goto retry;
                        }
                    }
                }
                else if (respond == "2")
                {
                    Console.WriteLine("You have 5 seconds to answer the following question:\n" +
                        "What is the answer to life, the universe and everything?");
                    Timer timer = new Timer(5000);
                    timer.Elapsed += (sneder, e) => HandleTimer2();
                    timer.Start();
                    respond = Console.ReadLine();
                    timer.Dispose();
                    timer.Stop();

                    if (respond == "42")
                    {
                        goto a2;
                    }
                    else if (respond == "yes" || respond == "no")
                    {
                        goto retry1;
                    }
                    else
                    {
                        goto a2;
                    }
                    retry1:
                    while (read)
                    {
                    retry:
                        Console.WriteLine("Play again?");
                        respond = Console.ReadLine();
                        if (respond == "yes")
                        {
                            goto repeat;
                        }
                        else if (respond == "no")
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            goto retry;
                        }
                    }
                a2:
                    if (respond != "42")
                    {
                        Console.WriteLine("Wrong! The answer is: 42");
                    }
                    else
                    {
                        Console.WriteLine("Well done!");
                    }
                    while (read)
                    {
                    retry:
                        Console.WriteLine("Play again?");
                        respond = Console.ReadLine();
                        if (respond == "yes")
                        {
                            goto repeat;
                        }
                        else if (respond == "no")
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            goto retry;
                        }
                    }
                }
                else if (respond == "3")
                {
                    Console.WriteLine("You have 5 seconds to answer the following question:\n" +
                        "What is the airspeed velocity of an unladen swallow?");
                    Timer timer = new Timer(5000);
                    timer.Elapsed += (sneder, e) => HandleTimer3();
                    timer.Start();
                    respond = Console.ReadLine();
                    timer.Dispose();
                    timer.Stop();

                    if (respond == "What do you mean? African or European swallow?")
                    {
                        goto a3;
                    }
                    else if (respond == "yes" || respond == "no")
                    {
                        goto retry1;
                    }
                    else
                    {
                        goto a3;
                    }
                    retry1:
                    while (read)
                    {
                    retry:
                        Console.WriteLine("Play again?");
                        respond = Console.ReadLine();
                        if (respond == "yes")
                        {
                            goto repeat;
                        }
                        else if (respond == "no")
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            goto retry;
                        }
                    }
                a3:
                    if (respond != "What do you mean? African or European swallow?")
                    {
                        Console.WriteLine("Wrong! The answer is: What do you mean? African or European swallow?");
                    }
                    else
                    {
                        Console.WriteLine("Well done!");
                    }
                    while (read)
                    {
                    retry:
                        Console.WriteLine("Play again?");
                        respond = Console.ReadLine();
                        if (respond == "yes")
                        {
                            goto repeat;
                        }
                        else if (respond == "no")
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            goto retry;
                        }
                    }
                }
            }
        }
    }
}
