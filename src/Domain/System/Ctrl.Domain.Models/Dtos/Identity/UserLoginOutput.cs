using System;
using Volo.Abp.Application.Dtos;

namespace Ctrl.Domain.Models.Dtos.Identity
{
    public class UserLoginOutput:IEntityDto<Guid>
    {
        /// <summary>
        ///     登录代码
        /// </summary>
        /// <value></value>
        public string Code { get; set; }

        public Guid Id { get; set; }
        /// <summary>
        ///     真实姓名
        /// </summary>
        /// <value></value>
        public string Name { get; set; }
        /// <summary>
        ///     是否是管理员
        /// </summary>
        /// <value></value>
        public bool IsAdmin { get; set; }
        ///// <summary>
        /////     角色名称
        ///// </summary>
        ///// <value></value>
        ////public string RoleName { get; set; }
        /// <summary>
        ///     是否冻结
        /// </summary>
        /// <value></value>
        public bool? IsFreeze { get; set; }
        /// <summary>
        ///     第一次登录时间
        /// </summary>
        /// <value></value>
        public DateTime? FirstVisitTime { get; set; }
        /// <summary>
        ///     头像地址
        /// </summary>
        public string ImgUrl { get; set; }

    }
}