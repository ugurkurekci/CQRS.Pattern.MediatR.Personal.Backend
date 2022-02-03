using MediatR;
using Models.Photo;

namespace Business.Commands;

public class CreatePhotoCommand : IRequest<int>
{
    public CreatePhotoModel CreatePhotoModel;

    public CreatePhotoCommand(CreatePhotoModel createPhotoModel)
    {
        CreatePhotoModel = createPhotoModel;
    }
}