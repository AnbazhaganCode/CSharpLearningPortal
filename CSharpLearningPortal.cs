using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningPortal
{
    public class CSharpLearningPortalObj
    {

        private SlowLearner _slowLearner = new SlowLearner();
        private MediumFastLearner _mediumFastLearner = new MediumFastLearner();
        private FastLearner _fastLearner = new FastLearner();

        public SlowLearner slowLearner
        {
            get
            {
                return _slowLearner;
            }
            set
            {
                _slowLearner = value;
            }
        }

        public MediumFastLearner mediumFastLearner
        {
            get
            {
                return _mediumFastLearner;
            }
            set
            {
                _mediumFastLearner = value;
            }
        }

        public FastLearner fastLearner
        {
            get
            {
                return _fastLearner;
            }
            set
            {
                _fastLearner = value;
            }
        }
    }
}
