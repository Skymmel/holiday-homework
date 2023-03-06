using System;
using System.Linq;

namespace Homework{
    internal class Program{
        public static void Main(string[] args){
            bool loop = true;
            short input;
            
            while(loop){
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Zadejte číslo úkolu: ");
                Console.ForegroundColor = ConsoleColor.Green;
                try{
                    input = short.Parse(Console.ReadLine());
                }
                catch{
                    input = -1;
                }
                Console.ResetColor();
                
                switch(input){
                    //zadání úkolu #3
                    case 1:
                        Console.ForegroundColor = ConsoleColor.White;
                        for(int i = 1; i <= 100; i++){
                            if(i == 40) continue;

                            if(i == 60) continue;

                            Console.WriteLine(i);
                        }
                        Console.ResetColor();
                        break;
                    
                    //zadání úkolu #2
                    case 2:
                        Console.Write("Výšku: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        int height = int.Parse(Console.ReadLine());
                        Console.ResetColor();
                        Console.Write("Šířku: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        int width = int.Parse(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        string star = " * ";
                        for(int i = 1; i <= height; i++)
                        for(int j = 1; j <= width; j++)
                            if(i == 1){
                                if(j == width){
                                    Console.WriteLine(star);
                                    continue;
                                }

                                Console.Write(star);
                            }
                            else if(i == height){
                                if(j == width){
                                    Console.WriteLine(" * ");
                                    continue;
                                }

                                Console.Write(star);
                            }
                            else{
                                if(j == 1)
                                    Console.Write(star);
                                else if(j == width)
                                    Console.WriteLine(star);
                                else
                                    Console.Write("   ");
                            }
                        Console.WriteLine();
                        Console.ResetColor();
                        break;
                    
                    //zadání úkolu #3
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("[!] Desetinnou čárku nahraďte '.'\n  např. 3.14 atd.");
                        Console.WriteLine("čísla dělte s mezerou, či čárkou.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Zadejte různá čísla: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        string numList = Console.ReadLine().Trim();
                        Console.ResetColor();
                        
                        int nums;
                        if(numList.Equals(""))
                            nums = 0;
                        else{
                            int decisiveChar;
                            if(numList.Contains(','))
                                decisiveChar = numList.Count(c => c == ',');
                            else
                                decisiveChar = numList.Count(c => c == ' ');
                            
                            if(decisiveChar == 0)
                                nums = 1;
                            else
                                nums = decisiveChar + 1;
                        }

                        Console.Write("Zadaný input obsahuje {0} ", nums);
                        if(nums == 1)
                            Console.WriteLine("číslo.");
                        else if(nums <= 4 && nums != 0)
                            Console.WriteLine("čísla.");
                        else Console.WriteLine("čísel.");
                        break;
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("[!] Ukončuji program...");
                        Console.ResetColor();
                        loop = false;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("[!] Zkuste napsat číšlo dáného úkoly ('1', '2', '3') znova, či pro konec napistě číslo '0'.");
                        Console.ResetColor();
                        break;
                }
            }
        }
    }
}