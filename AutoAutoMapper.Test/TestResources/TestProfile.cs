using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoAutoMapper.Test.TestResources
{
    public class TestProfile : Profile
    {
        protected override void Configure()
        {
            this.CreateMap<ClassA, ClassB>();
        }
    }
}
