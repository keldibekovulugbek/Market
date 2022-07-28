using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Market.Domain.Common
{
    public class ErrorResponse
    {
        [JsonIgnore]
        public int Code { get; set; }
        public string Message { get; set; }

        public ErrorResponse(int code, string message)
        {
            Code = code;
            Message = message;
        }
    }
}
