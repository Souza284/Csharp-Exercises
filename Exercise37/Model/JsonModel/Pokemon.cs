using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise37.Model.JsonModel
{
    public class Pokemon
    {
        private int Count { get; set; }
        private string? Next { get; set; }
        private object? Previous { get; set; }
        public List<Result>? Results { get; set; }
    }
}