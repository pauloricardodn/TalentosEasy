using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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

            container.Register<ICandidatoRepositorio, CandidatoRepositorio>();
            container.Register<ICandidatoService, CandidatoService>();

            container.Verify();
            return container;
        }
    }
}