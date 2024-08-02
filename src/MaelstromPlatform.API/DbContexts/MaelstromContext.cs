using Microsoft.EntityFrameworkCore;
using MaelstromPlatform.API.Issue;
using MaelstromPlatform.API.Person;
using MaelstromPlatform.API.Team;

namespace MaelstromPlatform.API.DbContexts
{
    public class MaelstromContext : DbContext
    {
        // Issue
        public DbSet<IssueEntity> Issues { get; set; }
        public DbSet<IssueApprovalEntity> IssueApprovals { get; set; }
        public DbSet<IssueApproverEntity> IssueApprovers { get; set; }
        public DbSet<IssueChampionEntity> IssueChampions { get; set; }
        public DbSet<IssueKindEntity> IssueKinds { get; set; }
        public DbSet<IssuePriorityEntity> IssuePriorities { get; set; }
        public DbSet<IssueSeverityEntity> IssueSeverities { get; set; }
        public DbSet<IssueStateEntity> IssueStates { get; set; }
        public DbSet<IssueStatusEntity> IssueStatuses { get; set; }

        // Person
        public DbSet<PersonEntity> People { get; set; }

        // Team
        public DbSet<TeamEntity> Teams { get; set; }

        public MaelstromContext(DbContextOptions<MaelstromContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new IssueEntityTypeConfiguration().Configure(modelBuilder.Entity<IssueEntity>());
            new IssueApprovalEntityTypeConfiguration().Configure(modelBuilder.Entity<IssueApprovalEntity>());
            new PersonEntityTypeConfiguration().Configure(modelBuilder.Entity<PersonEntity>());
        }
    }
}