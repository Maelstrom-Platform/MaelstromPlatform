namespace MaelstromPlatform.API.Issue
{
    public interface IIssueRepository
    {
        Task<IEnumerable<IssueEntity>> GetAllIssuesAsync();
        Task<IssueEntity> GetIssueByIdAsync(Guid id);
        Task<bool> SaveChangesAsync();
    }
}