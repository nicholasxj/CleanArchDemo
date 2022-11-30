using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(conf =>
            {
                conf.AddProfile(new ViewModelToDomainProfile());
                conf.AddProfile(new DomainToViewModelProfile());
            });
        }
    }
}
