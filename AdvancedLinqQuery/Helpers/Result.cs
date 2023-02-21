using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Practices.Helpers
{
    public class Result<T> where T: class
    {
        public IList Results { get; set; }
        public long Count { get; set; }

        public Result()
        {
            Results = new List<T>();
        }
    }
}
