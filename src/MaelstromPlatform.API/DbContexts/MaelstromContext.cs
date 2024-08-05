using Microsoft.EntityFrameworkCore;
using MaelstromPlatform.API.Attachment;
using MaelstromPlatform.API.Component;
using MaelstromPlatform.API.Customer;
using MaelstromPlatform.API.Document;
using MaelstromPlatform.API.Issue;
using MaelstromPlatform.API.Person;
using MaelstromPlatform.API.Product;
using MaelstromPlatform.API.Project;
using MaelstromPlatform.API.Tag;
using MaelstromPlatform.API.Team;

namespace MaelstromPlatform.API.DbContexts
{
    public class MaelstromContext : DbContext
    {
        // Attachment
        public DbSet<AttachmentEntity> Attachments { get; set; }
        public DbSet<IssueAttachmentEntity> IssueAttachments { get; set; }

        // Component
        public DbSet<ComponentEntity> Components { get; set; }

        // Customer
        public DbSet<CustomerEntity> Customers { get; set; }

        // Document
        public DbSet<DocumentEntity> Documents { get; set; }

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
        public DbSet<IssueCustomerEntity> IssueCustomers { get; set; }
        public DbSet<IssueDocumentEntity> IssueDocuments { get; set; }
        public DbSet<IssueProductEntity> IssueProducts { get; set; }
        public DbSet<IssueProjectEntity> IssueProjects { get; set; }
        public DbSet<IssueComponentEntity> IssueComponents { get; set; }
        public DbSet<IssueTagEntity> IssueTags { get; set; }

        // Person
        public DbSet<PersonEntity> People { get; set; }

        // Product
        public DbSet<ProductEntity> Products { get; set; }

        // Project
        public DbSet<ProjectEntity> Projects { get; set; }

        // Tag
        public DbSet<TagEntity> Tags { get; set; }

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
            new IssueCustomerEntityTypeConfiguration().Configure(modelBuilder.Entity<IssueCustomerEntity>());
            new IssueDocumentEntityTypeConfiguration().Configure(modelBuilder.Entity<IssueDocumentEntity>());
            new IssueProductEntityTypeConfiguration().Configure(modelBuilder.Entity<IssueProductEntity>());
            new IssueProjectEntityTypeConfiguration().Configure(modelBuilder.Entity<IssueProjectEntity>());
            new IssueComponentEntityTypeConfiguration().Configure(modelBuilder.Entity<IssueComponentEntity>());
            new IssueTagEntityTypeConfiguration().Configure(modelBuilder.Entity<IssueTagEntity>());
        }
    }
}