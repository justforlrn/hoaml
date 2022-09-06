﻿using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;
namespace Managerment;

[DependsOn(
    typeof(ManagermentDomainModule),
    typeof(ManagermentApplicationContractsModule),
    typeof(AbpDddApplicationModule)
    )]
public class ManagermentApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<ManagermentApplicationModule>();
        });
    }
}
