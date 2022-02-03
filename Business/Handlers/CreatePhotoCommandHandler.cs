using AutoMapper;
using Business.Commands;
using Data.Entities;
using MediatR;
using Repository.Abstracts;

namespace Business.Handlers;

public class CreatePhotoCommandHandler : IRequestHandler<CreatePhotoCommand, int>
{
    private readonly IPhotoRepository _photoRepository;
    private readonly IMapper _mapper;

    public CreatePhotoCommandHandler(IPhotoRepository photoRepository, IMapper mapper)
    {
        _photoRepository = photoRepository;
        _mapper = mapper;
    }

    public async Task<int> Handle(CreatePhotoCommand request, CancellationToken cancellationToken)
    {
        Photo project = _mapper.Map<Photo>(request.CreatePhotoModel);
        await _photoRepository.AddAsync(project);
        return await Task.FromResult(project.ID);
    }
}