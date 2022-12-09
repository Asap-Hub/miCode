using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwHrEmpsDocDetail
{
    public int EddIdpk { get; set; }

    public DateTime? EddDocDate { get; set; }

    public int? EddDocTypeIdfk { get; set; }

    public string? EddRmks { get; set; }

    public int? DtpIdpk { get; set; }

    public string? DtpName { get; set; }

    public string? DtpShtName { get; set; }

    public byte? DtpOrder { get; set; }

    public bool? DtpActive { get; set; }

    public DateTime? EddCreationDate { get; set; }

    public bool EddHasAttachment { get; set; }

    public int? EddEmpIdfk { get; set; }

    public int? EmpIdpk { get; set; }

    public string? EmpStaffNo { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpFirstName { get; set; }

    public string? EmpOthernames { get; set; }

    public string? EmpName { get; set; }

    public string? EmpName1 { get; set; }

    public string? EmpName2 { get; set; }

    public string? EmpName3 { get; set; }

    public string? EmpName4 { get; set; }

    public string? EmpName5 { get; set; }

    public string? EmpName6 { get; set; }

    public string? EmpName7 { get; set; }

    public string? EmpName8 { get; set; }

    public string? EmpName9 { get; set; }

    public string? EmpName10 { get; set; }

    public string? EmpName11 { get; set; }

    public string? EmpName12 { get; set; }

    public string? EmpName13 { get; set; }

    public string? EmpName14 { get; set; }

    public string? EmpName15 { get; set; }

    public string? EddTitle { get; set; }

    public string? EddDescription { get; set; }

    public string? EddType { get; set; }

    public bool? EddActive { get; set; }

    public bool EddClassified { get; set; }
}
