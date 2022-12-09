using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTmsFuelDumpComment
{
    public int FdcIdpk { get; set; }

    public int? FdcFuelDumpIdfk { get; set; }

    public string? FdcComment { get; set; }

    public bool? FdcActive { get; set; }

    public int? FdcCreatedBy { get; set; }

    public int FdmIdpk { get; set; }

    public DateTime? FdmDate { get; set; }

    public DateTime? FdcCreationDate { get; set; }

    public int EmpIdpk { get; set; }

    public string? EmpStaffNo { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpFirstName { get; set; }

    public string? EmpName { get; set; }

    public string? EmpName1 { get; set; }

    public string? EmpName2 { get; set; }

    public string? EmpName3 { get; set; }

    public string? EmpName4 { get; set; }

    public int? FdcEmpIdfk { get; set; }
}
