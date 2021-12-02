using AutoMapper;
using core3._1api.DTOs;
using core3._1api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core3._1api.Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Student, StudentDTO>().ReverseMap();
            CreateMap<studentCreationDTO,Student>();
        }
    }
}
