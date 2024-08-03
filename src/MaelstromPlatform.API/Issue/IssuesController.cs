using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace MaelstromPlatform.API.Issue
{
    [ApiController]
    [Route("api/issues")]
    public class IssuesController : ControllerBase
    {
        private readonly IIssueRepository _issueRepository;
        private readonly IMapper _mapper;

        public IssuesController(IIssueRepository issueRepository, IMapper mapper)
        {
            _issueRepository = issueRepository ?? throw new ArgumentNullException(nameof(issueRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet()]
        public async Task<ActionResult<IEnumerable<IssueForGetAllDto>>> GetAllIssuesAsync()
        {
            var issueEntities = await _issueRepository.GetAllIssuesAsync();

            return Ok(_mapper.Map<IEnumerable<IssueForGetAllDto>>(issueEntities));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IssueForGetByIdDto>> GetIssueByIdAsync(Guid id)
        {
            var issueEntities = await _issueRepository.GetIssueByIdAsync(id);

            return Ok(_mapper.Map<IssueForGetByIdDto>(issueEntities));
        }
    }
}