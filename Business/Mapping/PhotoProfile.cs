using AutoMapper;
using Data.Entities;
using Models.Photo;

namespace Business.Mapping;

public class PhotoProfile : Profile
{
    public PhotoProfile()
    {
        CreateMap<CreatePhotoModel, Photo>();
    }
}