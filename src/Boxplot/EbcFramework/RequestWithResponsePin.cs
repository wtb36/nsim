using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EbcFramework
{
    public class RequestWithResponsePin<TRequest, TResult>
    {
        public TRequest RequestData { get; private set; }
        public Action<TResult> ResponsePin { get; private set; }
        public RequestWithResponsePin(TRequest RequestData, Action<TResult> ResponsePin)
        {
            this.RequestData = RequestData;
            this.ResponsePin = ResponsePin;
        }
    }
}
