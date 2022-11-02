﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using RedNb.Auth.Domain.Shared.Enums;
using RedNb.Core.Domain;
using RedNb.Core.Domain.Audit;

namespace RedNb.Auth.Domain.Admins
{
    /// <summary>
    /// 角色实体类
    /// </summary>
    [Table("Role")]
    public class Role : AuditFullEntity, IHasTenant
    {
        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        /// <summary>
        /// 编码
        /// </summary>
        [Required]
        [MaxLength(20)]
        public string Key { get; set; }

        /// <summary>
        /// 排序号
        /// </summary>
        [Required]
        public decimal Sort { get; set; }

        /// <summary>
        /// 使用状态
        /// </summary>
        [Required]
        public EUsageStatus Status { get; set; }

        /// <summary>
        /// 租户编号
        /// </summary>
        public long TenantId { get; set; }

        public virtual Tenant Tenant { get; set; }

        public bool IsSystem { get; set; }
    }
}
