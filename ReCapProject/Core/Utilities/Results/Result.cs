using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{// özellikler sadece get tanımlı fakat constructor içinde set edilebilir.
    // constructor dışında set edemeyiz,böylece verilen değerlerin sonradan değişmesini önlüyoruz.
    public class Result : IResult
    {
       

        public Result(bool success, string message):this(success)
        {
            this.Message = message;
          
        }
        // mesaj vermek istemeyebiliriz, bu ihtimale karşı farklı bir constructor oluşturduk
        // constructor owerloading
        public Result(bool success)
        {
            this.Success = success;
           
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
