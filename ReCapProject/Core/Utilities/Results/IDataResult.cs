using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{ // işlem sonucunu zaten IResult içerdiği için
    //tekrar yazmak yerine onu dahil ettik
   public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
