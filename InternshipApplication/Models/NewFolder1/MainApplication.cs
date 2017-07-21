using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternshipApplication.Models.NewFolder1
{
    public class MainApplication
    {
        public int MainApplicationID { get; set; }
        public string studentFirstName { get; set; }
        public string studentMiddleName { get; set; }
        public string studentLastName { get; set; }
        public int wNum { get; set; }
        public string studentEmail { get; set; }
        public int studentCellPhone { get; set; }
        public int studentWorkPhone { get; set; }
        public string studentPresentAddress { get; set; }
        public string studentPermanentAddress { get; set; }
        //public bool isStudentInternational { get; set; }
        //public string Major { get; set; }
        public string Degree { get; set; }
        public string Concentration { get; set; }
        //public string AcademicTerm { get; set; }
        //public int semesterHoursEarned { get; set; }
        //public decimal majorGPA { get; set; }  //maybe change to float or something smaller than decimal? 
        //public DateTime expectededGraduationDate { get; set; }
        public bool isPartTime { get; set; }
      
        public bool isSignedByStudentApplication { get; set; }
        public DateTime dateApplicationReceivedByyDept { get; set; }
        public bool IsApplicationApprovedByDept { get; set; }
        public string reasonWhyOrWhyNotApplicationIsApprovedByDept { get; set; }
        public bool isApplicationFormSignedByInstructor { get; set; }
        public DateTime dataInstructorSignedApplicationForm { get; set; }
        public bool IsApplicationSignedByDeptHead { get; set; }
        public DateTime dateApplicationsignedByDeptHead { get; set; }
        public bool isApplicationSignedByDean { get; set; }
        public DateTime dateApplicationSignedByDean { get; set; }
        public enum semesterOfInternship { fall, spring, summer }
        public bool isSignedByAcademicAdvisor { get; set; }
        public DateTime dataSignedByAcademicAdvisor { get; set; }
        public bool isSignedBySupervisorUponCompletion { get; set; }
        public DateTime dataSupervisorSignedUponCompletion { get; set; }
        public string employersName { get; set; }
        public string employersAddress { get; set; }
        public string supervisorName { get; set; }
        public string supervisorTitle { get; set; }
        public string supervisorEmail { get; set; }
        public int supervisorPhone { get; set; }
        public DateTime employmentBeginDate { get; set; }
        public DateTime employmentEndingDate { get; set; }
        public string jobTitle { get; set; }
        public string jobResponsibilities { get; set; }
        //public enum salaryType { BiWeekly, Monthly, Hourly }
        //public double salary { get; set; }  //is double really nessary??? 
    }
}
