using AutoMapper;
using DC = Exception.Demo.RESTAPI.API.DataContracts;
using S = Exception.Demo.RESTAPI.Services.Model;

namespace Exception.Demo.RESTAPI.IoC.Configuration.Profiles
{
    public class APIMappingProfile : Profile
    {
        public APIMappingProfile()
        {
            CreateMap<S.User, DC.User>();
            CreateMap<S.Adress, DC.Adress>();
        }
    }
}
