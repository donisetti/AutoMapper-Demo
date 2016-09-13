using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Automapper_Demo;
using AutoMapper.Mappers;

namespace Automapper_Demo.Mappings
{
    public class DomainToViewModelMappingProfile:Profile
    {
        public override string ProfileName
        {
            get
            {
                return "DomainToViewModelMappings";
            }
        }

        [Obsolete]
        protected override void Configure()
        {
            CreateMap<AutomapperDemo.Entities.Contact, Models.ContactForm>();
        }
    }

}
