using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Good
{
    public class RadioCommunicator
    {
        private ITypeCommunicator communicator;

        public RadioCommunicator(ITypeCommunicator communicator) {
            this.communicator = communicator;
        }

        public void Communucate(ISoldier soldier1, ISoldier soldier2) {
            communicator.Communicate(soldier1, soldier2);
        }
    }
}
