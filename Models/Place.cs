using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AvaloniaApplication3.Models
{
    public class Place
    {

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string? Street { get; set; }
        public string? House { get; set; }
        public int Grade { get; set; }
        public string? Type { get; set; }
        public string? Comment { get; set; }
        
    }
}
