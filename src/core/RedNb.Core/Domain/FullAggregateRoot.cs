﻿using RedNb.Core.Util;

namespace RedNb.Core.Domain;

public class FullAggregateRoot : AggregateRoot<long>
{
    /// <summary>
    /// 主键
    /// </summary>
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    [Column(Order = 0)]
    [Comment("主键")]
    public override long Id { get; protected set; }

    public FullAggregateRoot()
    {
        Id = IdentityManager.NewId();
    }
}
