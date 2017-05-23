using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace WhatWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            StopWatch stopWatch = new StopWatch();

            string input = Console.ReadLine();
            //stopWatch.Start();
            {
                while (input == "s")
                {
                   stopWatch.startTime = DateTime.Now;
                    Console.WriteLine("When 's' is hit, the timer will start.");
                    
                    if (input == "x")
                    {
                        stopWatch.Stop();
                        {
                            stopWatch.stopTime = new DateTime();
                            Console.WriteLine("Hit 'x' to end timer.");
                            Console.ReadLine();

                        }
                        break;
                    }
                }
                Console.WriteLine("The time that elapsed was " + stopWatch.ElapsedTime);
                Console.ReadLine();
                {
                    
                }
            }
          }
        }
    }
