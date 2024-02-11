﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Datalagring.Entities
{
    internal class RoleEntity
    {
        [Key]
        public int Id { get; set; }
        public string RoleName { get; set; } = null!;
    }
}