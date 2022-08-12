﻿using System;
using System.ComponentModel.DataAnnotations;

namespace APIGames.models
{
    public class GameModel
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set;}
        public string Description { get; set;}
        [Required]
        public double Price { get; set; }
    }
}
