using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrEmpNameDetail
{
    public int EndIdpk { get; set; }

    public string? EndStaffNo { get; set; }

    public string? EndLastName { get; set; }

    public string? EndFirstName { get; set; }

    public string? EndOtherNames { get; set; }

    public string? EndLegacyName { get; set; }

    public string? EndInitials { get; set; }

    public string? EndNickname { get; set; }

    public int? EndOrgIdfk { get; set; }

    public bool? EndActive { get; set; }

    public string? EndRmks { get; set; }

    public int? EndCreatedBy { get; set; }

    public int? EndEditedBy { get; set; }

    public DateTime? EndCreationDate { get; set; }

    public DateTime? EndEditedDate { get; set; }
}
