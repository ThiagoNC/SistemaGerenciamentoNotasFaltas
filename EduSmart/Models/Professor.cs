using System;
using System.Collections.Generic;
using System.Text;

namespace EduSmart.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string SenhaHash { get; set; }
    }
}
