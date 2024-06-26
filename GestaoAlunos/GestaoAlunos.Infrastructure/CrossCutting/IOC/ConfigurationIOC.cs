using Autofac;
using GestaoAlunos.Application;
using GestaoAlunos.Application.Interfaces;
using GestaoAlunos.Application.Interfaces.Mappers;
using GestaoAlunos.Application.Mappers;
using GestaoAlunos.Domain.Core.Interfaces.Repositories;
using GestaoAlunos.Domain.Core.Interfaces.Services;
using GestaoAlunos.Domain.Services;
using GestaoAlunos.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Infrastructure.CrossCutting.IOC
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

            builder.RegisterType<MapperClient>().As<IMapperClient>();
            builder.RegisterType<MapperProduct>().As<IMapperProduct>();


            #endregion
        }
    }
}
