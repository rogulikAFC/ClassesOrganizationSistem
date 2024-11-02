﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassesOrganizationSistem.Domain.Entities.RoomEntities
{
    public class RoomStatus
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public bool IsOpened { get; set; } = true;

        [MaxLength(64)]
        public string? Description { get; set; }
    }
}