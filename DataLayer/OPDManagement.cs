//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class OPDManagement
    {
        public int SerialNo { get; set; }
        public string ReferenceNo { get; set; }
        public string FullName { get; set; }
        public string PhoneNo { get; set; }
        public string EmailId { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public string DoctorCode { get; set; }
        public Nullable<System.DateTime> AppointmentDate { get; set; }
        public Nullable<int> AvaibilityMasterId { get; set; }
        public string AppointmentTime { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string AllergyDetail { get; set; }
        public string Casedetail { get; set; }
        public string PreviousPrescreption { get; set; }
        public string CaseImage { get; set; }
        public string Treated { get; set; }
        public string DoctorFeedback { get; set; }
    }
}
