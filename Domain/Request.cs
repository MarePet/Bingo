using System;

namespace Domain
{
    [Serializable]
    public class Request
    {
        public object RequestObject { get; set; }
        public Operacija Operacija { get; set; }
        public Request(object requestObject, Operacija operacija)
        {
            RequestObject = requestObject;
            Operacija = operacija;
        }
    }
}
