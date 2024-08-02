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

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() >= 0);
        }
    }
}