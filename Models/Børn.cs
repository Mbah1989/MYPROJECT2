﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MYPROJECT2.Models;

[Table("Børn")]
public partial class Børn
{
    [Key]
    [Column("CHILD_ID")]
    public int ChildId { get; set; }

    [Required]
    [Column("NAME")]
    [StringLength(50)]
    public string Name { get; set; }

    [Required]
    [Column("ADDRESS")]
    [StringLength(50)]
    public string Address { get; set; }

    [Column("AGE")]
    public int Age { get; set; }

    [Column("GROUP_ID")]
    public int? GroupId { get; set; }

    [Column("START ", TypeName = "datetime")]
    public DateTime Start { get; set; }

    [InverseProperty("Child")]
    public virtual ICollection<Assigment> Assigments { get; set; } = new List<Assigment>();

    [ForeignKey("GroupId")]
    [InverseProperty("Børns")]
    public virtual Group Group { get; set; }

    [InverseProperty("Child")]
    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}