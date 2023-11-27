using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningPortal
{
    public class console
    {
        public void HelloWorld() 
        {
            Console.WriteLine("Hello world!");
        }

        public void SelfIntro()
        {
            Console.WriteLine("Hi!");
            Console.WriteLine("My name is Anbu.");
            Console.WriteLine("I am a software engineer.");
            Console.WriteLine("I am doing YouTube as a passion.");
        }

        public void SingleLineSelfIntro()
        {
            Console.Write("Hi!");
            Console.Write("My name is Anbu.");
            Console.Write("I am a software engineer.");
            Console.Write("I am doing YouTube as a passion.");
        }
        /// <summary>
        /// Displays the Teater Ticket Menu for Anbu Theater, showcasing the current movie listings,
        /// screen information, and corresponding ticket prices. Assumes that the required objects
        /// (CSharpLearningPortalObj, SlowLearner, and console) are properly initialized before calling.
        /// </summary>
        public void Project_TeaterTicketMenu()
        {
            Console.WriteLine(" *******************************");
            Console.WriteLine(" *   Welcome to Anbu theater!  *");
            Console.WriteLine(" *******************************");
            Console.WriteLine(" * ------ Now Showing -------- *");
            Console.WriteLine(" * Screen 1: Leo               *");
            Console.WriteLine(" * Screen 2: Leo               *");
            Console.WriteLine(" * Screen 3: Jawan             *");
            Console.WriteLine(" * ---------Price------------- *");
            Console.WriteLine(" * Leo   : 210₹                *");
            Console.WriteLine(" * Jawan : 110₹                *");
            Console.WriteLine(" *******************************");
            Console.WriteLine(" *    Have a memorable day!    *");
            Console.WriteLine(" *******************************");

        }
    }
}
