using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPjmTeamMember
{
    public int TmbIdpk { get; set; }

    public int? TmbEmpIdfk { get; set; }

    public int? TmbTeamIdfk { get; set; }

    public int? TmbProjectIdfk { get; set; }

    public DateTime? TmbStartDate { get; set; }

    public DateTime? TmbEndDate { get; set; }

    public string? TmbMemberName { get; set; }

    public int? TmbRoleIdfk { get; set; }

    public string? TmbOrganisation { get; set; }

    public string? TmbJobTitle { get; set; }

    public int? TmbNationalityIdfk { get; set; }

    public string? TmbContactNos { get; set; }

    public string? TmbEmail { get; set; }

    public bool? TmbStaff { get; set; }

    public bool? TmbActive { get; set; }

    public string? TmbRmks { get; set; }

    public int? TmbCreatedBy { get; set; }

    public int? TmbEditedBy { get; set; }

    public DateTime? TmbCreationDate { get; set; }

    public DateTime? TmbEditedDate { get; set; }
}
