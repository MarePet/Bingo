using System;

namespace Domain
{
    [Serializable]
    public class Response
    {
        public object ResponseObject { get; set; }
        public bool IsSuccesful { get; set; }
    }
}
