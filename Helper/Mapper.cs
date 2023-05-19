using AutoMapper;
using WebApplication2.Dto;
using WebApplication2.Models;

namespace WebApplication2.Helper;

public class Mapper: Profile
{
    public Mapper()
    {
        CreateMap<Pokemon, PokemonDto>();
        CreateMap<Category, CategoryDto>();
        CreateMap<CategoryDto, Category>();
        CreateMap<CountryDto, Country>();
        CreateMap<OwnerDto, Owner>();
        CreateMap<PokemonDto, Pokemon>();
        CreateMap<ReviewDto, Review>();
        CreateMap<ReviewerDto, Reviewer>();
        CreateMap<Country, CountryDto>();
        CreateMap<Owner, OwnerDto>();
        CreateMap<Review, ReviewDto>();
        CreateMap<Reviewer, ReviewDto>();
    }
}