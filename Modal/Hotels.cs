using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace secondyear.Modal
{
    public class Hotels
    {
        [Key]
        public int Id { get; set; }
        public string name {get;set;} = String.Empty;
        public string image {get;set;}
        public string description {get;set;}
        public string price {get;set;}
    }
}