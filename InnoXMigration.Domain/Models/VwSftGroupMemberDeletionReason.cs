using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSftGroupMemberDeletionReason
{
    public int GdrIdpk { get; set; }

    public int? GdrEmpIdfk { get; set; }

    public int? GdrGroupIdfk { get; set; }

    public DateTime? GdrDate { get; set; }

    public string? GdrReason { get; set; }

    public bool? GdrActive { get; set; }

    public int SgpIdpk { get; set; }

    public string? SgpShtName { get; set; }

    public string? SgpName { get; set; }

    public DateTime? SgpDateFormed { get; set; }

    public bool? SgpActive { get; set; }

    public int EmpIdpk { get; set; }

    public string? EmpStaffNo { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpFirstname { get; set; }

    public string EmpOtherNames { get; set; } = null!;

    public string? EmpName { get; set; }

    public string? DeletedByStaffNo { get; set; }

    public string? DeletedByLname { get; set; }

    public string? DeletedByEmpName { get; set; }
}
