﻿using RedNb.Core.Domain;

namespace RedNb.WebGateway.Domain.Routes;

[Table("Match")]
public class Match : EntityBase
{
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    public virtual Route Route { get; set; }
}