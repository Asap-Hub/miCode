using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwPjmTeamMember
{
    public int TmbIdpk { get; set; }

    public int? TmbEmpIdfk { get; set; }

    public bool? TmbActive { get; set; }

    public int? PtmIdpk { get; set; }

    public string? PtmName { get; set; }

    public string? PtmShtName { get; set; }

    public bool? PtmActive { get; set; }

    public int? TmbTeamIdfk { get; set; }

    public string? TmbMemberName { get; set; }

    public string? TmbOrganisation { get; set; }

    public string? TmbJobTitle { get; set; }

    public string? TmbContactNos { get; set; }

    public string? TmbEmail { get; set; }

    public string? TmbRmks { get; set; }

    public int? TmbProjectIdfk { get; set; }

    public DateTime? TmbStartDate { get; set; }

    public DateTime? TmbEndDate { get; set; }

    public int PjrIdpk { get; set; }

    public string? PjrName { get; set; }

    public string? PjrShtName { get; set; }

    public DateTime? PjrStartDate { get; set; }

    public DateTime? PjrProposedEndDate { get; set; }

    public int? RolIdpk { get; set; }

    public string? RolName { get; set; }

    public string? RolShtName { get; set; }

    public int? TmbRoleIdfk { get; set; }

    public int? TmbNationalityIdfk { get; set; }

    public int? CtyIdpk { get; set; }

    public string? CtyName { get; set; }

    public string? CtyShtName { get; set; }

    public string? CtyNationality { get; set; }

    public string? CtyCapital { get; set; }

    public DateTime? PtmStartDate { get; set; }

    public DateTime? PtmEndDate { get; set; }

    public bool TmbStaff { get; set; }
}
