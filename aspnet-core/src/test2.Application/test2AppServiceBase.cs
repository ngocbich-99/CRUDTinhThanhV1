﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Abp.Application.Services;
using Abp.IdentityFramework;
using Abp.Runtime.Session;
using test2.Authorization.Users;
using test2.MultiTenancy;

namespace test2
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class test2AppServiceBase : ApplicationService
    {
        //đơn vị thuê hệ thống của mình 
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        protected test2AppServiceBase()
        {
            //đa ngôn ngữ 
            LocalizationSourceName = test2Consts.LocalizationSourceName;
        }

        protected virtual async Task<User> GetCurrentUserAsync()
        {
            var user = await UserManager.FindByIdAsync(AbpSession.GetUserId().ToString());
            if (user == null)
            {
                throw new Exception("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
