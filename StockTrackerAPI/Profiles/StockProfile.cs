using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockTrackerAPI.Profiles
{
    /**
     * Automapper Profile class for Stock Entity
     * */
    public class StockProfile : Profile
    {
        public StockProfile()
        {
            CreateMap<Entities.Stock, Models.StockDto>();   //GET 
            CreateMap<Models.StockCreationDto, Entities.Stock>();   //POST
        }


    }
}
