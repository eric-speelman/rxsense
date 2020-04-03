using System;
using System.Collections.Generic;
using System.Text;

namespace RxSense.FizzBuzz
{
    public interface IFizzBuzz
    {
        //For numbers which are multiples of both three and five return FizzBuzz.
        //For multiples of three return Fizz
        //For multiples of five return Buzz
        //Return Flat for all other numbers
        FizzBuzzType GetFizzBuzz(int val);
    }
}
