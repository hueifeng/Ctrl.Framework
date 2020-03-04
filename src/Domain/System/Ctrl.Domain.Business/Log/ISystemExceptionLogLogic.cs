﻿using Ctrl.Core.Business;
using Ctrl.Core.Entities.Paging;
using Ctrl.Domain.Models.Dtos.Logs;
using Ctrl.Domain.Models.Entities;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Ctrl.Domain.Business.Log
{
    /// <summary>
    ///     异常日志业务逻辑接口
    /// </summary>
    public interface ISystemExceptionLogLogic: IAsyncLogic<SystemExceptionLog>, IScopedDependency
    {
        Task<PagedResults<SystemExceptionLog>> PagingExceptionLogQuery(SystemLoginLogPagingInput query);
    }
}
