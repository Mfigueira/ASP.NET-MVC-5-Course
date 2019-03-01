﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public GenreDto Genre { get; set; }

        public DateTime ReleaseDate { get; set; }

        public DateTime CreationDate { get; set; }

        [Range(1, 20)]
        public byte NumberInStock { get; set; }
    }
}