using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {

        // result sadece true ya da false olsun mesaj donmesin. bunun icin 2 constructor olustur.
        // 2. constructor her sekilde calisacagindan ve kod tekrar yapilmamasi icin constructor duzenlendi
        // alttaki constructor icinde sadece message degiskenini set eder, sonuncdaki tihs(success) 2. constructor i cagirip success parametresini gonderiri
        // do not repeat yourself!!!!
        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }
        public string Message { get; }
    }
}
