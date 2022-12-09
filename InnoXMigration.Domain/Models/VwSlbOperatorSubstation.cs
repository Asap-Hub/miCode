using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSlbOperatorSubstation
{
    public int OsaIdpk { get; set; }

    public string? OsaOprIdfk { get; set; }

    public string? OsaSstIdfk { get; set; }

    public bool? OsaActive { get; set; }

    public string? OsaRmks { get; set; }

    public int OprIdpk { get; set; }

    public int? EmpIdpk { get; set; }

    public string UsaUsername { get; set; } = null!;

    public string? DptShtName { get; set; }

    public string? SxnShtName { get; set; }

    public string? LocShtName { get; set; }

    public string? EmpName { get; set; }

    public string? EmpName1 { get; set; }

    public int StnIdpk { get; set; }

    public string? StnName { get; set; }

    public string? StnShtName { get; set; }

    public bool? StnActive { get; set; }

    public int? OprEmpIdfk { get; set; }

    public string? EmpStaffNo { get; set; }

    public DateTime? OsaCreationDate { get; set; }

    public DateTime? OsaEditedDate { get; set; }

    public string? StnCode { get; set; }

    public string? StnContact { get; set; }

    public string? StnTelNo { get; set; }

    public string? StnPlc { get; set; }

    public string? StnRmks { get; set; }
}
