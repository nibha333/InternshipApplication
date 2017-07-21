using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace InternshipApplication.Migrations
{
    public partial class MySecond : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MainApplication",
                columns: table => new
                {
                    MainApplicationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Concentration = table.Column<string>(nullable: true),
                    Degree = table.Column<string>(nullable: true),
                    IsApplicationApprovedByDept = table.Column<bool>(nullable: false),
                    IsApplicationSignedByDeptHead = table.Column<bool>(nullable: false),
                    dataInstructorSignedApplicationForm = table.Column<DateTime>(nullable: false),
                    dataSignedByAcademicAdvisor = table.Column<DateTime>(nullable: false),
                    dataSupervisorSignedUponCompletion = table.Column<DateTime>(nullable: false),
                    dateApplicationReceivedByyDept = table.Column<DateTime>(nullable: false),
                    dateApplicationSignedByDean = table.Column<DateTime>(nullable: false),
                    dateApplicationsignedByDeptHead = table.Column<DateTime>(nullable: false),
                    employersAddress = table.Column<string>(nullable: true),
                    employersName = table.Column<string>(nullable: true),
                    employmentBeginDate = table.Column<DateTime>(nullable: false),
                    employmentEndingDate = table.Column<DateTime>(nullable: false),
                    isApplicationFormSignedByInstructor = table.Column<bool>(nullable: false),
                    isApplicationSignedByDean = table.Column<bool>(nullable: false),
                    isPartTime = table.Column<bool>(nullable: false),
                    isSignedByAcademicAdvisor = table.Column<bool>(nullable: false),
                    isSignedByStudentApplication = table.Column<bool>(nullable: false),
                    isSignedBySupervisorUponCompletion = table.Column<bool>(nullable: false),
                    jobResponsibilities = table.Column<string>(nullable: true),
                    jobTitle = table.Column<string>(nullable: true),
                    reasonWhyOrWhyNotApplicationIsApprovedByDept = table.Column<string>(nullable: true),
                    studentCellPhone = table.Column<int>(nullable: false),
                    studentEmail = table.Column<string>(nullable: true),
                    studentFirstName = table.Column<string>(nullable: true),
                    studentLastName = table.Column<string>(nullable: true),
                    studentMiddleName = table.Column<string>(nullable: true),
                    studentPermanentAddress = table.Column<string>(nullable: true),
                    studentPresentAddress = table.Column<string>(nullable: true),
                    studentWorkPhone = table.Column<int>(nullable: false),
                    supervisorEmail = table.Column<string>(nullable: true),
                    supervisorName = table.Column<string>(nullable: true),
                    supervisorPhone = table.Column<int>(nullable: false),
                    supervisorTitle = table.Column<string>(nullable: true),
                    wNum = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainApplication", x => x.MainApplicationID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MainApplication");
        }
    }
}
