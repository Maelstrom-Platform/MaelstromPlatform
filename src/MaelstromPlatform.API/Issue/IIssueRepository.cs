namespace MaelstromPlatform.API.Issue
{
    public interface IIssueRepository
    {
        Task<IEnumerable<IssueEntity>> GetAllIssuesAsync();
        Task<bool> SaveChangesAsync();
    }
}