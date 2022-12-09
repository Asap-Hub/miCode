using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblOraPaymentToBank
{
    public int Idpk { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public string? StaffNo { get; set; }

    public string? StaffName { get; set; }

    public string? StaffNamex { get; set; }

    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public string? Onames { get; set; }

    public string? AccountNo { get; set; }

    public decimal? Amount { get; set; }

    public string? Department { get; set; }

    public string? Section { get; set; }

    public string? Bank { get; set; }

    public string? Branch { get; set; }

    public string? BranchCode { get; set; }

    public string? MobileNo { get; set; }

    public string? JobTitle { get; set; }

    public string? Grade { get; set; }

    public string? Step { get; set; }

    public decimal? AnnualSalary { get; set; }

    public string? Location { get; set; }

    public string? PersonType { get; set; }

    public string? AssignmentStatus { get; set; }

    public string? AssignmentCategory { get; set; }

    public string? Supervisor { get; set; }

    public bool? SmsSent { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreationDate { get; set; }
}
