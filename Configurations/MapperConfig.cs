using AutoMapper;
using BankClientApi.Data;
using BankClientApi.Models.City;
using BankClientApi.Models.Client;

namespace BankClientApi.Configurations
{
    public class MapperConfig : Profile
    {
        //automapper for easy mapping between the Dto and the db model
        public MapperConfig()
        {
            CreateMap<Client, CreateClientDto>().ReverseMap();
            CreateMap<Client, GetClientDto>().ReverseMap();
            CreateMap<City, GetCityDto>().ReverseMap();
        }
    }
}
