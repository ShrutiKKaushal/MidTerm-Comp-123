using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_MidTermExam
{
    class Lotto649: LottoGame
    {
        // PRIVATE INSTANCE VARIABLES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private int[] _lottoElementArray;

        // CONSTRUCTOR ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public Lotto649()
            : base(6,49)
        {
            this._generateLottoNumbers();
            
        }

        private void _generateLottoNumbers()
        {
            /* NOTE: Things to complete for this method:
             * 1. Create an outer Loop that initializes a local string variable elementString to an empty string literal.
             * Call the public pickElements method and assign it to the private _lottoElementArray Instance Variable.
             * This loop will be used to generate the 5 sets of numbers.
             * 
             * 2. Create an inner Loop that iterates through each of the elements of _lottoElementArray 
             * and concatenate each of the elements into a local string variable, elementString. 
             * Each element (lotto number) should be separated by a space.
             * 
             * 3. Back in the outer loop, output the resultant elementString to the console. Again make sure the outer loop
             * iterates 5 times.
             */


            for(int index = 0; index < 5; index++)
            {

                string elementString = "";

                this._lottoElementArray = pickElements();
                // Assign pickElement to _LottoElementArray

                for(int element = 0; element < 6; element++)
                {
                    // Loop through _lottoElementArray
                    elementString += this._lottoElementArray[element] + " ";
                    // elementString += an element from element array +" ";

                }
                Console.WriteLine(elementString);
            }
        }
    }
}
