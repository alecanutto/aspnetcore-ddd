﻿using Autofac;
using AutoMapper;
using Project_Model_DDD.Application;
using Project_Model_DDD.Application.Interfaces;
using Project_Model_DDD.Application.Mappers;
using Project_Model_DDD.Domain.Core.Interfaces.Repositories;
using Project_Model_DDD.Domain.Core.Interfaces.Services;
using Project_Model_DDD.Domain.Services;
using Project_Model_DDD.Infra.Data.Repositories;

namespace Project_Model_DDD.Infra.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServiceClient>().As<IApplicationServiceClient>();
            builder.RegisterType<ApplicationServiceProduct>().As<IApplicationServiceProduct>();
            builder.RegisterType<ServiceClient>().As<IServiceClient>();
            builder.RegisterType<ServiceProduct>().As<IServiceProduct>();
            builder.RegisterType<RepositoryClient>().As<IRepositoryClient>();
            builder.RegisterType<RepositoryProduct>().As<IRepositoryProduct>();
            builder.Register(ctx => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DtoToModelMappingClient());
                cfg.AddProfile(new ModelToDtoMappingClient());
                cfg.AddProfile(new DtoToModelMappingProduct());
                cfg.AddProfile(new ModelToDtoMappingProduct());

            }));

            builder.Register(ctx => ctx.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>().InstancePerLifetimeScope();
        }

        #endregion IOC
    }

}