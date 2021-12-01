using System;

namespace Library
{
    public class ArrayList
    {
        private int[] _array;

        private int _currentCount;

        public ArrayList()
        {
            _array = new int[5];
            _currentCount = 0;
        }

        public void Add(int number)
        {
            if(_currentCount != _array.Length)
            {
                _array[_currentCount] = number;
            }
            else
            {
                int[] newArray = new int[(int)(_array.Length * 1.33)];
                for (int i = 0; i < _array.Length; i++)
                {
                    newArray[i] = _array[i];
                }

                newArray[_currentCount] = number;
                _array = newArray;
            }

            ++_currentCount;
        }

        public int DeleteByValue(int value)
        {
            int index = -1;
            for (int i = 0; i < _currentCount; i++)
            {
                if(_array[i] == value)
                {
                    index = i;
                    break;
                }
            }

            --_currentCount;
            for (int i = index; i < _currentCount; i++)
            {
                _array[i] = _array[i + 1];
            }

            return index;
        }

        public void Print()
        {
            for (int i = 0; i < _currentCount; i++)
            {
                Console.Write($"{_array[i]} ");
            }
        }
    }
}
