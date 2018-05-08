using SimpleInjector;
using SimpleInjector.Lifestyles;
using TalentosEasy.Dados.Repositorios;
using TalentosEasy.Dominio.Interfaces.Repositorios;
using TalentosEasy.Dominio.Interfaces.Services;
using TalentosEasy.Dominio.Services;

namespace TalentosEasy.App_Start
{
    public static class SimpleInjectorContainer
    {
        public static Container RegisterServices()
        {
            var container = new Container();

            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            container.Register<ICandidatoRepositorio, CandidatoRepositorio>();
            container.Register<ICandidatoService, CandidatoService>();

            container.Verify();
            return container;
        }
    }
}