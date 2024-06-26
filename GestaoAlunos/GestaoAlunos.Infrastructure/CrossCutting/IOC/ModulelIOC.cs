using Autofac;

namespace GestaoAlunos.Infrastructure.CrossCutting.IOC
{
    public class ModulelIOC : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            ConfigurationIOC.Load(builder);
        }
    }
}
