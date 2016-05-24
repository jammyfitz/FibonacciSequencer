using System.Collections.Generic;
using System.Linq;

namespace FibonacciSequence
{
    public class Sequencer
    {
        private int _currentNumber;
        private int _mostPreviousNumber;
        private int _immediatelyPreviousNumber;
        private List<int> _fibonacciSequence;

        public Sequencer()
        {
            _currentNumber = 1;
            _immediatelyPreviousNumber = 1;
            _mostPreviousNumber = 0;
            _fibonacciSequence = Generate(100);
        }

        public int GetPosition(int position)
        {
            return _fibonacciSequence[position - 1];
        }

        private List<int> Generate(int numberOfItems)
        {
            List<int> items = new List<int>(numberOfItems);
            items.Add(_mostPreviousNumber);
            items.Add(_immediatelyPreviousNumber);
            items.Add(_currentNumber);
            _mostPreviousNumber = 1;
            _immediatelyPreviousNumber = 1;

            for (int i = 0; i < numberOfItems; i++)
            {
                _currentNumber = _immediatelyPreviousNumber + _mostPreviousNumber;

                items.Add(_currentNumber);

                _mostPreviousNumber = _immediatelyPreviousNumber;
                _immediatelyPreviousNumber = _currentNumber;
            }

            return items.Take(numberOfItems).ToList();
        }
    }
}
