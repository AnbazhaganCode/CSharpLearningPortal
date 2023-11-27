using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
