using System;
using System.Collections.Generic;
using System.Text;

namespace Util
{
    public static class ExtensionMethods
    {
        public static int toInt(this string value) //this keyword is required for this instance of the object
        {
            return int.Parse(value); //the returned value has been intParsed
        }
    }
    
    class Console //because Console is a built-in class, in order for us to be able to use Console as our class name,
                  //we need to change the namespace as well as add System to the front of the Console.Writeline()'s
                  //on this page.
    {
        static public string Ask(string question)
        {
            System.Console.Write(question); 
            return System.Console.ReadLine();
        }
        
        static public int AskInt(string question)
        {
            try
            {
                System.Console.Write(question);   
                
                //return int.Parse(System.Console.ReadLine());
                return System.Console.ReadLine().toInt(); //the toInt method is now running the intParse
            }
            catch (Exception)
            {
                throw new FormatException("Input was not a number");
            }
            
        }
    }
}