using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwMtsUserDocUnitAssign
{
    public int UdaIdpk { get; set; }

    public int? UdaUserIdfk { get; set; }

    public int? UdaAssignUnitIdfk { get; set; }

    public DateTime? UdaDate { get; set; }

    public string? UdaRmks { get; set; }

    public string? EmpStaffNo { get; set; }

    public int? UsaEmpIdfk { get; set; }

    public string? UsaUsername { get; set; }

    public string? EmpName { get; set; }

    public int? DptIdpk { get; set; }

    public string? DptName { get; set; }

    public int UsaIdpk { get; set; }

    public int DcuIdpk { get; set; }

    public string? DcuName { get; set; }

    public string? DcuShtName { get; set; }

    public string? DcuCode { get; set; }

    public bool? DcuActive { get; set; }

    public string? DcuRmks { get; set; }

    public string? Dcu1stCode { get; set; }

    public string? Dcu2ndCode { get; set; }

    public string? Dcu3rdCode { get; set; }

    public string? Dcu4thCode { get; set; }

    public bool? UdaActive { get; set; }
}
