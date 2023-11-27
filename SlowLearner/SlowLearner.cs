using System;

namespace CSharpLearningPortal
{
    public class SlowLearner
    {
        private console _console = new console();
        public console console 
        {
            get
            {
                return _console;
            }
            set
            {
                _console = value;
            }
        }
        
    }
}
