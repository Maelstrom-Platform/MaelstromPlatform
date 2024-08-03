using MaelstromPlatform.API.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace MaelstromPlatform.API.Issue
{
    public class IssueRepository : IIssueRepository
    {
        private readonly MaelstromContext _context;

        public IssueRepository(MaelstromContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<IssueEntity>> GetAllIssuesAsync()
        {
            return await _context.Issues.ToListAsync();
        }

        public async Task<IssueEntity> GetIssueByIdAsync(Guid id)
        {
            return await _context.Issues.Where(i => i.SysId == id).FirstOrDefaultAsync();
        }

        public async Task AddIssueAsync(IssueEntity issueEntity)
        {
            await _context.Issues.AddAsync(issueEntity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() >= 0);
        }
    }
}