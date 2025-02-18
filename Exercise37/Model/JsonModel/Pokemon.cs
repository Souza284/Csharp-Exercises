using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Exercise37.Model.JsonModel
{
    public class Pokemon
    {
        public int count { get; set; }
        public string? next { get; set; }
        public object? previous { get; set; }
        //public List<Result>? results { get; set; }
    }
}