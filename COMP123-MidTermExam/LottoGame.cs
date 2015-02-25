using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_MidTermExam
{
    // ABSTRACT CLASS LOTTOGAME
    abstract class LottoGame
    {
        // PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private int[] _numberArray = new int[50];
        private int[] _elementArray = new int[7];
        private int _elementNum;
        private int _setSize;
        private Random _rnd = new Random(); // Generates random number

        // CONSTRUCTTOR +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public LottoGame(int elementNum, int setSize)
        {
            this._elementNum = elementNum;
            this._setSize = setSize;
            _initialize();

        }

        // PRIVATE METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private void _initialize()
        {
            for(int index = 0; index <= this._setSize; index++)
            {
                this._numberArray[index] = index + 1;
            }
        }
        

        // PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public int[] pickElements()
        {
            // generates a random set of numbers
            // set the _elementArray to 6 or 7 unique values
            int count = 0;

            while (count < this._elementNum)
            {
                int randomIndex = this._rnd.Next(this._setSize); // random number

                // check if random number is unique
                if (this._numberArray[randomIndex] != 0)
                {
                    this._elementArray[count] = this._numberArray[randomIndex];
                    this._numberArray[randomIndex] = 0;
                    count++;
                }
            }

            return this._elementArray;
        }
    }
}
