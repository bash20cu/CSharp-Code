using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalApps
{
    internal class StringsSolution
    {
        public static void stringSolution()
        {
            Console.WriteLine("Strings Solutions ");
            Console.WriteLine(" Uso del IndexOf para extraer Cadenas ");

            //string message = "Find what is (inside the parentheses)";

            //int openingPosition = message.IndexOf('(');
            //int closingPosition = message.IndexOf(')');
            //Console.WriteLine(" ");
            //Console.WriteLine($"{ message},  Parentheses start at position: {openingPosition} , End in position: {closingPosition}");
            //openingPosition += 1;
            //int length = closingPosition - openingPosition;
            //Console.WriteLine(message.Substring(openingPosition, length));



            //string message = "What is the value <span>between the tags</span>?";

            ////int openingPosition = message.IndexOf("<span>");
            ////int closingPosition = message.IndexOf("</span>");

            //////Avoid use Magic numbers instead use Constants
            //const string openSpan = "<span>";
            //const string closeSpan = "</span>";
            //int openingPosition = message.IndexOf(openSpan);
            //int closingPosition = message.IndexOf(closeSpan);

            //Console.WriteLine(" ");
            //Console.WriteLine($"{ message},  Tags start at position: {openingPosition} , End in position: {closingPosition}");

            ////openingPosition += 6;
            //openingPosition += openSpan.Length;

            //int length = closingPosition - openingPosition;
            //Console.WriteLine($"Value:  {message.Substring(openingPosition, length)}");

            /* 
             Código para recuperar cualquier valor entre uno o más conjuntos de paréntesis en una cadena 
             */
            string message = "(What if) there are (more than) one (set of parentheses)?";
            Console.WriteLine(" ");
            Console.Write(message);
            Console.WriteLine(" ");            
            while (true)
            {
                int openingPosition = message.IndexOf('(');
                if (openingPosition == -1) break;

                openingPosition += 1;
                Console.WriteLine($"Open parentheses on position: {openingPosition}");

                int closingPosition = message.IndexOf(')');
                int length = closingPosition - openingPosition;
                Console.WriteLine($"Closed parentheses on position: {closingPosition}");
                Console.WriteLine($"Charachter lengths: {length}");
                

                Console.WriteLine(message.Substring(openingPosition, length));
                Console.WriteLine(" ");

                // Note how we use the overload of Substring to return only the remaining 
                // unprocessed message:
                message = message.Substring(closingPosition + 1);
            }
            


        }
    }
}
