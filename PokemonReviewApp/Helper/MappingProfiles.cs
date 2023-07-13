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
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();
            CreateMap<CountryDto, Country>();
            CreateMap<PokemonDto, Pokemon>();
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
