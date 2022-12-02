﻿using RedNb.Core.Domain;

namespace RedNb.WebGateway.Domain.Routes;

[Table("Route")]
public class Route : AggregateRootBase
{
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }
}