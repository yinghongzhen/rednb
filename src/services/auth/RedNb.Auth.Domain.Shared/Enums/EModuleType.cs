﻿using System.ComponentModel;

namespace RedNb.Auth.Domain.Shared.Enums;

/// <summary>
/// 模块类型
/// </summary>
[Description("模块类型")]
public enum EModuleType
{
    /// <summary>
    /// 基础微服务
    /// </summary>
    [Description("基础微服务")]
    Base = 0,

    /// <summary>
    /// 聚合微服务
    /// </summary>
    [Description("聚合微服务")]
    Aggregate = 1
}
