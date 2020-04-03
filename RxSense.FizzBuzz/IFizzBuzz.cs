using System;
using System.Collections.Generic;
using System.Text;

namespace RxSense.FizzBuzz
{
    public interface IFizzBuzz
    {
        //For numbers which are multiples of both three and five return FizzBuzz.
        //For multiples of three return Fizz
        //
        FizzBuzzType GetFizzBuzz(int val);
    }
}
