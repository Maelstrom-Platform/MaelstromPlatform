namespace MaelstromPlatform.API.Issue
{
    public interface IIssueRepository
    {
        Task<IEnumerable<IssueEntity>> GetAllIssuesAsync();
        Task<IssueEntity> GetIssueByIdAsync(Guid id);
        Task AddIssueAsync(IssueEntity issueEntity);
        Task<bool> SaveChangesAsync();
    }
}