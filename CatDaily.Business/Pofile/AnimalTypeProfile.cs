using AutoMapper;
using CatDaily.Business.Models.RequestModel;
using CatDaily.Business.Models.ResponseModel;
using CatDaily.DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatDaily.Business.Pofile
{
    public class AnimalTypeProfile:Profile
    {
        public AnimalTypeProfile()
        {
            CreateMap<AnimalType, GetAnimalTypeListResponseModel>();       
            CreateMap<AddAnimalTypeRequestModel, AnimalType>();
            CreateMap<AnimalType, GetAnimalTypeByIdResponseModel>();
        }
    }
}
