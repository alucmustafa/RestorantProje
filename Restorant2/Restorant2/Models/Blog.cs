﻿using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;

namespace Restorant2.Models
{
    public class Blog
    {
        [Key]
       public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public string  Image { get; set; }
        public bool  Oany { get; set; }
        [Required]
        public string Mesaj { get; set; }
        public DateTime Tarih { get; set; }

    }
}
