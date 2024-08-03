using AutoMapper;

namespace MaelstromPlatform.API.Issue
{
    public class IssueProfile : Profile
    {
        public IssueProfile()
        {
            CreateMap<IssueEntity, IssueForGetAllDto>().ReverseMap();
            CreateMap<IssueEntity, IssueForGetByIdDto>().ReverseMap();
        }
    }
}