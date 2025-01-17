﻿using RedNb.Core.Domain;

namespace RedNb.Gateway.Domain.Clusters;

[Table("Destination")]
public class Destination : BaseEntity
{
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    public virtual Cluster Cluster { get; set; }
}