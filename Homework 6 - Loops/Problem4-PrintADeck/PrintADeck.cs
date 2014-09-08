using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4_PrintADeck
{
    class PrintADeck
    {
        static void Main()
        {
            
            char spade = '\u2660';
            char heart = '\u2665';
            char diamond = '\u2666';
            char club = '\u2663';
            //Console.WriteLine("{0}{1}{2}{3}",spade, heart,diamond,club);
           
           for (int i = 2; i < 15; i++)
            {
                		    
                   switch (i)
                    {
                        case 2: Console.Write("{0}{1}", i, spade);
                            Console.Write("{0}{1}", i, heart);
                            Console.Write("{0}{1}", i, diamond);
                            Console.WriteLine("{0}{1}", i, club);
                            break;
                        case 3: Console.Write("{0}{1}", i, spade);
                            Console.Write("{0}{1}", i, heart);
                            Console.Write("{0}{1}", i, diamond);
                            Console.WriteLine("{0}{1}", i, club);
                    
                            break;
                        case 4: Console.Write("{0}{1}", i, spade);
                            Console.Write("{0}{1}", i, heart);
                            Console.Write("{0}{1}", i, diamond);
                            Console.WriteLine("{0}{1}", i, club);
                          
                            break;
                        case 5: Console.Write("{0}{1}", i, spade);
                            Console.Write("{0}{1}", i, heart);
                            Console.Write("{0}{1}", i, diamond);
                            Console.WriteLine("{0}{1}", i, club);
                           
                            break;
                        case 6: Console.Write("{0}{1}", i, spade);
                            Console.Write("{0}{1}", i, heart);
                            Console.Write("{0}{1}", i, diamond);
                            Console.WriteLine("{0}{1}", i, club);
                         
                            break;
                        case 7: Console.Write("{0}{1}", i, spade);
                            Console.Write("{0}{1}", i, heart);
                            Console.Write("{0}{1}", i, diamond);
                            Console.WriteLine("{0}{1}", i, club);
                 
                            break;
                        case 8: Console.Write("{0}{1}", i, spade);
                            Console.Write("{0}{1}", i, heart);
                            Console.Write("{0}{1}", i, diamond);
                            Console.WriteLine("{0}{1}", i, club);
                
                            break;
                        case 9: Console.Write("{0}{1}", i, spade);
                            Console.Write("{0}{1}", i, heart);
                            Console.Write("{0}{1}", i, diamond);
                            Console.WriteLine("{0}{1}", i, club);
             
                            break;
                        case 10: Console.Write("{0}{1}", i, spade);
                            Console.Write("{0}{1}", i, heart);
                            Console.Write("{0}{1}", i, diamond);
                            Console.WriteLine("{0}{1}", i, club);
          
                            break;                          
                        case 11: Console.Write("J{0}", spade);
                            Console.Write("J{0}", heart);
                            Console.Write("J{0}", diamond);
                            Console.WriteLine("J{0}", club);
             
                            break;
                        case 12: Console.Write("Q{0}", spade);
                            Console.Write("Q{0}", heart);
                            Console.Write("Q{0}", diamond);
                            Console.WriteLine("Q{0}", club);
             
                            break;
                        case 13: Console.Write("K{0}", spade);
                            Console.Write("K{0}", heart);
                            Console.Write("K{0}", diamond);
                            Console.WriteLine("K{0}", club);
        
                            break;
                        case 14:  Console.Write("A{0}", spade);
                            Console.Write("A{0}", heart);
                            Console.Write("A{0}", diamond);
                            Console.Write("A{0}", club);
            
                            break;
                                default :  break;
                    }
           }
           
            }
    }
        }
    


