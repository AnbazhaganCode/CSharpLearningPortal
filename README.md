# CSharpLearningPortal
This product was useful to learn CSharp. 

How to use this project.
---------------------------------------------------------------
Code snippet:
---------------------------------------------------------------
using System;

using CSharpLearningPortal;

namespace YourNamespace
{
    public class HelloWorld
    {
        public static void Main(string[] args)
        {
            CSharpLearningPortalObj cSharp = new CSharpLearningPortalObj();

            SlowLearner slowLearner = cSharp.slowLearner;

            console console = slowLearner.console;
            
            console.Project_TeaterTicketMenu();

        }
    }
}
 --------------------------------------------------------------
 Output
 --------------------------------------------------------------
  *******************************
 *   Welcome to Anbu theater!  *
 *******************************
 * ------ Now Showing -------- *
 * Screen 1: Leo               *
 * Screen 2: Leo               *
 * Screen 3: Jawan             *
 * ---------Price------------- *
 * Leo   : 210?                *
 * Jawan : 110?                *
 *******************************
 *    Have a memorable day!    *
 *******************************
