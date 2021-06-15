using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CsvHelper__ASP.NET_Core.Models
{
    public class Student
    {
        [Index (0)]
        public string Nome { get; set; } = "";
        [Index(2)]
        public string Codigo { get; set; } = "";
        [Index(1)]
        public string Email { get; set; } = "";

    }
}
