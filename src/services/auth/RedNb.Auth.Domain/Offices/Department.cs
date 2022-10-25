﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using RedNb.Auth.Domain.Shared.Enums;
using RedNb.Auth.Domain.Admins;
using Volo.Abp.Domain.Entities;

namespace RedNb.Auth.Domain.Offices
{
    /// <summary>
    /// 组织机构实体类
    /// </summary>
    [Table("Department")]
    public class Department : AggregateRoot<long>
    {
        /// <summary>
        /// 编码
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Key { get; set; }

        /// <summary>
        /// 负责人
        /// </summary>
        [MaxLength(100)]
        public string Leader { get; set; }

        /// <summary>
        /// 办公电话
        /// </summary>
        [MaxLength(100)]
        public string Phone { get; set; }

        /// <summary>
        /// 联系地址
        /// </summary>
        [MaxLength(255)]
        public string Address { get; set; }

        /// <summary>
        /// 邮政编码
        /// </summary>
        [MaxLength(100)]
        public string ZipCode { get; set; }

        /// <summary>
        /// 电子邮箱
        /// </summary>
        [MaxLength(300)]
        public string Email { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [MaxLength(500)]
        public string Desc { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// 租户编号
        /// </summary>
        public long TenantId { get; set; }

        public virtual Tenant Tenant { get; set; }
    }
}
