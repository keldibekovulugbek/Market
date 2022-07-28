using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Market.Domain.Common
{
    public class BaseResponse<TSource>
    {
        [JsonIgnore]
        public int Code { get; set; } = 200;

        public TSource Data { get; set; }

        public ErrorResponse Error { get; set; }
    }
}
