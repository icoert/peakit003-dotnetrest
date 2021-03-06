﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LearningQ.BL.Models
{
    public class Queue : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public List<Item> Items { get; set; } = new List<Item>();
    }
}
