using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using InternshipApplication.Models;

namespace InternshipApplication.Migrations
{
    [DbContext(typeof(InternshipApplicationContext))]
    partial class InternshipApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InternshipApplication.Models.NewFolder1.MainApplication", b =>
                {
                    b.Property<int>("MainApplicationID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Concentration");

                    b.Property<string>("Degree");

                    b.Property<bool>("IsApplicationApprovedByDept");

                    b.Property<bool>("IsApplicationSignedByDeptHead");

                    b.Property<DateTime>("dataInstructorSignedApplicationForm");

                    b.Property<DateTime>("dataSignedByAcademicAdvisor");

                    b.Property<DateTime>("dataSupervisorSignedUponCompletion");

                    b.Property<DateTime>("dateApplicationReceivedByyDept");

                    b.Property<DateTime>("dateApplicationSignedByDean");

                    b.Property<DateTime>("dateApplicationsignedByDeptHead");

                    b.Property<string>("employersAddress");

                    b.Property<string>("employersName");

                    b.Property<DateTime>("employmentBeginDate");

                    b.Property<DateTime>("employmentEndingDate");

                    b.Property<bool>("isApplicationFormSignedByInstructor");

                    b.Property<bool>("isApplicationSignedByDean");

                    b.Property<bool>("isPartTime");

                    b.Property<bool>("isSignedByAcademicAdvisor");

                    b.Property<bool>("isSignedByStudentApplication");

                    b.Property<bool>("isSignedBySupervisorUponCompletion");

                    b.Property<string>("jobResponsibilities");

                    b.Property<string>("jobTitle");

                    b.Property<string>("reasonWhyOrWhyNotApplicationIsApprovedByDept");

                    b.Property<int>("studentCellPhone");

                    b.Property<string>("studentEmail");

                    b.Property<string>("studentFirstName");

                    b.Property<string>("studentLastName");

                    b.Property<string>("studentMiddleName");

                    b.Property<string>("studentPermanentAddress");

                    b.Property<string>("studentPresentAddress");

                    b.Property<int>("studentWorkPhone");

                    b.Property<string>("supervisorEmail");

                    b.Property<string>("supervisorName");

                    b.Property<int>("supervisorPhone");

                    b.Property<string>("supervisorTitle");

                    b.Property<int>("wNum");

                    b.HasKey("MainApplicationID");

                    b.ToTable("MainApplication");
                });
        }
    }
}
