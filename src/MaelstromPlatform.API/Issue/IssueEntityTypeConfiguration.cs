using MaelstromPlatform.API.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaelstromPlatform.API.Issue
{
    public class IssueEntityTypeConfiguration : IEntityTypeConfiguration<IssueEntity>
    {
        public void Configure(EntityTypeBuilder<IssueEntity> builder)
        {
            builder
                .HasOne(i => i.FoundByPrimaryPerson)
                .WithMany(p => p.IssuesFound)
                .HasForeignKey(i => i.FoundByPrimaryPersonSysId)
                .OnDelete(DeleteBehavior.ClientNoAction);

            builder
                .HasOne(i => i.ReportedByPrimaryPerson)
                .WithMany(p => p.IssuesReported)
                .HasForeignKey(i => i.ReportedByPrimaryPersonSysId)
                .OnDelete(DeleteBehavior.ClientNoAction);

            builder
                .HasOne(i => i.PrimaryChampion)
                .WithMany(p => p.IssuesChampioned)
                .HasForeignKey(i => i.PrimaryChampionSysId)
                .OnDelete(DeleteBehavior.ClientNoAction);

            builder
                .HasOne(i => i.PrimaryOwner)
                .WithMany(p => p.IssuesOwned)
                .HasForeignKey(i => i.PrimaryOwnerSysId)
                .OnDelete(DeleteBehavior.ClientNoAction);

            builder
                .HasOne(i => i.PrimaryOwnerTeam)
                .WithMany(t => t.IssuesOwned)
                .HasForeignKey(i => i.PrimaryOwnerTeamSysId)
                .OnDelete(DeleteBehavior.ClientNoAction);

            builder
                .HasOne(i => i.PrimaryFoundByTeam)
                .WithMany(t => t.IssuesFound)
                .HasForeignKey(i => i.PrimaryFoundByTeamSysId)
                .OnDelete(DeleteBehavior.ClientNoAction);

            builder
                .HasOne(i => i.PrimaryReportedByTeam)
                .WithMany(t => t.IssuesReported)
                .HasForeignKey(i => i.PrimaryReportedByTeamSysId)
                .OnDelete(DeleteBehavior.ClientNoAction);

            builder
                .Property(i => i.Identifier)
                .IsRequired()
                .HasMaxLength(Constants.Identifier);

            builder
                .Property(i => i.SummaryBrief)
                .IsRequired()
                .HasMaxLength(Constants.SummaryBrief);

            builder
                .Property(i => i.SummaryLong)
                .IsRequired()
                .HasMaxLength(Constants.SummaryLong);

            builder
                .Property(i => i.Origin)
                .IsRequired()
                .HasDefaultValueSql("GETUTCDATE()");

            builder
                .Property(i => i.FoundOn)
                .IsRequired()
                .HasDefaultValueSql("GETUTCDATE()");

            builder
                .Property(i => i.ReportedOn)
                .IsRequired()
                .HasDefaultValueSql("GETUTCDATE()");

            builder
                .Property(i => i.ProblemStatement)
                .IsRequired()
                .HasMaxLength(Constants.LargeText);

            builder
                .Property(i => i.WorkAround)
                .IsRequired()
                .HasMaxLength(Constants.LargeText);

            builder
                .Property(i => i.StepsToReproduce)
                .IsRequired()
                .HasMaxLength(Constants.LargeText);
        }
    }
}
