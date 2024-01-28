using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ckorost
{
    internal class Tekst
    {
        public int[] text()
        {
            long time = 0;
            int txt = 0;
            string s = "Завидуй, будь чёрствым, не бойся, ещё разЗавидуй, будь чёрствым, не бойся, ещё разЗавидуй, будь чёрствым, не бойся, ещё разЗавидуй, будь чёрствым, не бойся, ещё раз"; //41 164
            char[] a = s.ToCharArray();
                Stopwatch stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < 164; i++)
            {
                char k = a[i];
                while (true)
                {
                stopwatch.Restart();
                    char key = Console.ReadKey(true).KeyChar;
                    if (key == k)
                    {
                        txt = txt + 1;
                        if (i < 41)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(i, 0);
                            Console.WriteLine(k);
                        }
                        else
                        {
                            if (i < 82)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.SetCursorPosition(i - 41, 1);
                                Console.WriteLine(k);
                            }
                            else
                            {
                                if(i < 123)
                                {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.SetCursorPosition(i - 82, 2);
                                Console.WriteLine(k);

                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.SetCursorPosition(i - 123, 3);
                                    Console.WriteLine(k);
                                }
                            }
                        }
                        stopwatch.Stop();

                        time = time + stopwatch.ElapsedMilliseconds;
                        break;
                    }
                    stopwatch.Stop();

                    time = time + stopwatch.ElapsedMilliseconds;
                    if (time > 60000)
                    {
                        time = 60000;
                        break;
                    }
                }
                if (time == 60000)
                {
                    break;
                }
            }
            int tim =Convert.ToInt32( time / 1000);
            int[] back = { txt, tim };
            return back;
        }
    }
}
