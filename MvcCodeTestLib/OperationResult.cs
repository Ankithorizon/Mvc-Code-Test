using System;
using System.Collections.Generic;
using System.Text;

namespace MvcCodeTestLib
{
    public class OperationResult
    {
        public string Message { get; set; }
        public List<string> ModelErrors { get; set; }
        public int StatusCode { get; set; }
    }
}
