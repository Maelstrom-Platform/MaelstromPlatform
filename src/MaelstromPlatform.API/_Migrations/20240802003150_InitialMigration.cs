using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaelstromPlatform.API._Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IssueChampions",
                columns: table => new
                {
                    SysId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssueChampions", x => x.SysId);
                });

            migrationBuilder.CreateTable(
                name: "IssueKinds",
                columns: table => new
                {
                    SysId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Identifier = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Kind = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Usage = table.Column<string>(type: "nvarchar(max)", maxLength: 8192, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssueKinds", x => x.SysId);
                });

            migrationBuilder.CreateTable(
                name: "IssuePriorities",
                columns: table => new
                {
                    SysId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Identifier = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Priority = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Usage = table.Column<string>(type: "nvarchar(max)", maxLength: 8192, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssuePriorities", x => x.SysId);
                });

            migrationBuilder.CreateTable(
                name: "IssueSeverities",
                columns: table => new
                {
                    SysId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Identifier = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Severity = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Usage = table.Column<string>(type: "nvarchar(max)", maxLength: 8192, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssueSeverities", x => x.SysId);
                });

            migrationBuilder.CreateTable(
                name: "IssueStates",
                columns: table => new
                {
                    SysId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Identifier = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    State = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Usage = table.Column<string>(type: "nvarchar(max)", maxLength: 8192, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssueStates", x => x.SysId);
                });

            migrationBuilder.CreateTable(
                name: "IssueStatuses",
                columns: table => new
                {
                    SysId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Identifier = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Usage = table.Column<string>(type: "nvarchar(max)", maxLength: 8192, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssueStatuses", x => x.SysId);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    SysId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Identifier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.SysId);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    SysId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Identifier = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.SysId);
                });

            migrationBuilder.CreateTable(
                name: "IssueApprovers",
                columns: table => new
                {
                    SysId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonEntitySysId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Optional = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssueApprovers", x => x.SysId);
                    table.ForeignKey(
                        name: "FK_IssueApprovers_People_PersonEntitySysId",
                        column: x => x.PersonEntitySysId,
                        principalTable: "People",
                        principalColumn: "SysId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Issues",
                columns: table => new
                {
                    SysId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Identifier = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SummaryBrief = table.Column<string>(type: "nvarchar(72)", maxLength: 72, nullable: false),
                    SummaryLong = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Origin = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    Approved = table.Column<bool>(type: "bit", nullable: false),
                    IssueStateSysId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IssueStatusSysId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Resolved = table.Column<bool>(type: "bit", nullable: false),
                    IssueSeveritySysId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IssuePrioritySysId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IssueKindSysId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProblemStatement = table.Column<string>(type: "nvarchar(max)", maxLength: 8192, nullable: false),
                    WorkAround = table.Column<string>(type: "nvarchar(max)", maxLength: 8192, nullable: false),
                    StepsToReproduce = table.Column<string>(type: "nvarchar(max)", maxLength: 8192, nullable: false),
                    PrimaryOwnerSysId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PrimaryOwnerTeamSysId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PrimaryFoundByTeamSysId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PrimaryReportedByTeamSysId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PrimaryChampionSysId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FoundByPrimaryPersonSysId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReportedByPrimaryPersonSysId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FoundOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    ReportedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Issues", x => x.SysId);
                    table.ForeignKey(
                        name: "FK_Issues_IssueKinds_IssueKindSysId",
                        column: x => x.IssueKindSysId,
                        principalTable: "IssueKinds",
                        principalColumn: "SysId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Issues_IssuePriorities_IssuePrioritySysId",
                        column: x => x.IssuePrioritySysId,
                        principalTable: "IssuePriorities",
                        principalColumn: "SysId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Issues_IssueSeverities_IssueSeveritySysId",
                        column: x => x.IssueSeveritySysId,
                        principalTable: "IssueSeverities",
                        principalColumn: "SysId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Issues_IssueStates_IssueStateSysId",
                        column: x => x.IssueStateSysId,
                        principalTable: "IssueStates",
                        principalColumn: "SysId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Issues_IssueStatuses_IssueStatusSysId",
                        column: x => x.IssueStatusSysId,
                        principalTable: "IssueStatuses",
                        principalColumn: "SysId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Issues_People_FoundByPrimaryPersonSysId",
                        column: x => x.FoundByPrimaryPersonSysId,
                        principalTable: "People",
                        principalColumn: "SysId");
                    table.ForeignKey(
                        name: "FK_Issues_People_PrimaryChampionSysId",
                        column: x => x.PrimaryChampionSysId,
                        principalTable: "People",
                        principalColumn: "SysId");
                    table.ForeignKey(
                        name: "FK_Issues_People_PrimaryOwnerSysId",
                        column: x => x.PrimaryOwnerSysId,
                        principalTable: "People",
                        principalColumn: "SysId");
                    table.ForeignKey(
                        name: "FK_Issues_People_ReportedByPrimaryPersonSysId",
                        column: x => x.ReportedByPrimaryPersonSysId,
                        principalTable: "People",
                        principalColumn: "SysId");
                    table.ForeignKey(
                        name: "FK_Issues_Teams_PrimaryFoundByTeamSysId",
                        column: x => x.PrimaryFoundByTeamSysId,
                        principalTable: "Teams",
                        principalColumn: "SysId");
                    table.ForeignKey(
                        name: "FK_Issues_Teams_PrimaryOwnerTeamSysId",
                        column: x => x.PrimaryOwnerTeamSysId,
                        principalTable: "Teams",
                        principalColumn: "SysId");
                    table.ForeignKey(
                        name: "FK_Issues_Teams_PrimaryReportedByTeamSysId",
                        column: x => x.PrimaryReportedByTeamSysId,
                        principalTable: "Teams",
                        principalColumn: "SysId");
                });

            migrationBuilder.CreateTable(
                name: "IssueApprovals",
                columns: table => new
                {
                    SysId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IssueEntitySysId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IssueApproverEntitySysId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssueApprovals", x => x.SysId);
                    table.ForeignKey(
                        name: "FK_IssueApprovals_IssueApprovers_IssueApproverEntitySysId",
                        column: x => x.IssueApproverEntitySysId,
                        principalTable: "IssueApprovers",
                        principalColumn: "SysId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IssueApprovals_Issues_IssueEntitySysId",
                        column: x => x.IssueEntitySysId,
                        principalTable: "Issues",
                        principalColumn: "SysId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_IssueApprovals_IssueApproverEntitySysId",
                table: "IssueApprovals",
                column: "IssueApproverEntitySysId");

            migrationBuilder.CreateIndex(
                name: "IX_IssueApprovals_IssueEntitySysId",
                table: "IssueApprovals",
                column: "IssueEntitySysId");

            migrationBuilder.CreateIndex(
                name: "IX_IssueApprovers_PersonEntitySysId",
                table: "IssueApprovers",
                column: "PersonEntitySysId");

            migrationBuilder.CreateIndex(
                name: "IX_Issues_FoundByPrimaryPersonSysId",
                table: "Issues",
                column: "FoundByPrimaryPersonSysId");

            migrationBuilder.CreateIndex(
                name: "IX_Issues_IssueKindSysId",
                table: "Issues",
                column: "IssueKindSysId");

            migrationBuilder.CreateIndex(
                name: "IX_Issues_IssuePrioritySysId",
                table: "Issues",
                column: "IssuePrioritySysId");

            migrationBuilder.CreateIndex(
                name: "IX_Issues_IssueSeveritySysId",
                table: "Issues",
                column: "IssueSeveritySysId");

            migrationBuilder.CreateIndex(
                name: "IX_Issues_IssueStateSysId",
                table: "Issues",
                column: "IssueStateSysId");

            migrationBuilder.CreateIndex(
                name: "IX_Issues_IssueStatusSysId",
                table: "Issues",
                column: "IssueStatusSysId");

            migrationBuilder.CreateIndex(
                name: "IX_Issues_PrimaryChampionSysId",
                table: "Issues",
                column: "PrimaryChampionSysId");

            migrationBuilder.CreateIndex(
                name: "IX_Issues_PrimaryFoundByTeamSysId",
                table: "Issues",
                column: "PrimaryFoundByTeamSysId");

            migrationBuilder.CreateIndex(
                name: "IX_Issues_PrimaryOwnerSysId",
                table: "Issues",
                column: "PrimaryOwnerSysId");

            migrationBuilder.CreateIndex(
                name: "IX_Issues_PrimaryOwnerTeamSysId",
                table: "Issues",
                column: "PrimaryOwnerTeamSysId");

            migrationBuilder.CreateIndex(
                name: "IX_Issues_PrimaryReportedByTeamSysId",
                table: "Issues",
                column: "PrimaryReportedByTeamSysId");

            migrationBuilder.CreateIndex(
                name: "IX_Issues_ReportedByPrimaryPersonSysId",
                table: "Issues",
                column: "ReportedByPrimaryPersonSysId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IssueApprovals");

            migrationBuilder.DropTable(
                name: "IssueChampions");

            migrationBuilder.DropTable(
                name: "IssueApprovers");

            migrationBuilder.DropTable(
                name: "Issues");

            migrationBuilder.DropTable(
                name: "IssueKinds");

            migrationBuilder.DropTable(
                name: "IssuePriorities");

            migrationBuilder.DropTable(
                name: "IssueSeverities");

            migrationBuilder.DropTable(
                name: "IssueStates");

            migrationBuilder.DropTable(
                name: "IssueStatuses");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
