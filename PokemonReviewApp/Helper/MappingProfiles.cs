using AutoMapper;
using PokemonReviewApp.Dtos;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles() 
        {
            CreateMap<Pokemon, PokemonDto>();
            CreateMap<CategoryDto, Category>();
            CreateMap<Category, CategoryDto>();
            CreateMap<PokemonDto, Pokemon>();
            CreateMap<CountryDto, Country>();
            CreateMap<Country, CountryDto>();
            CreateMap<ReviewDto, Review>();
            CreateMap<ReviewerDto, Reviewer>();
            CreateMap<OwnerDto, Owner>();
            CreateMap<Owner, OwnerDto>();
            CreateMap<Review, ReviewDto>();  
            CreateMap<Reviewer, ReviewerDto>();
        }
    }
}
