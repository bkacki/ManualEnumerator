using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManualEnumerator
{
    internal class BetterSportSequence : IEnumerable<Sport>
    {
        public IEnumerator<Sport> GetEnumerator()
        {
            int maxEnumValue = Enum.GetValues(typeof(Sport)).Length - 1;
            for (int i = 0; i < maxEnumValue; i++)
                yield return (Sport)i;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Sport this[int index]
        {
            get { return (Sport)index; }
        }
    }
}
