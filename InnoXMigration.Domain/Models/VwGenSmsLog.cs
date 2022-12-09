using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwGenSmsLog
{
    public int SlgIdpk { get; set; }

    public string? SlgMessage { get; set; }

    public string? SlgMobNo { get; set; }

    public string? SlgSender { get; set; }

    public bool? SlgSent { get; set; }

    public string? SlgFormCode { get; set; }

    public int EmpIdpk { get; set; }

    public string? EmpStaffNo { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpFirstName { get; set; }

    public string? EmpName { get; set; }

    public string? EmpName16 { get; set; }

    public DateTime? SlgCreationDate { get; set; }

    public string EmpMobNo { get; set; } = null!;

    public string EmpMobNox { get; set; } = null!;

    public string? EmpName1 { get; set; }

    public string? EmpName2 { get; set; }

    public string? EmpName12 { get; set; }

    public string? EmpName3 { get; set; }

    public int DptIdpk { get; set; }

    public string DptName { get; set; } = null!;

    public string DptShtName { get; set; } = null!;

    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public int JbtIdpk { get; set; }

    public string JbtName { get; set; } = null!;

    public string JbtShtName { get; set; } = null!;

    public int? SlgInitiatorEmpIdfk { get; set; }

    public int? InitEmpId { get; set; }

    public string? InitStaffNo { get; set; }

    public string? InitLname { get; set; }

    public string? InitFname { get; set; }

    public string? InitEmpName { get; set; }

    public string? InitEmpName12 { get; set; }

    public int? InitDptId { get; set; }

    public string? InitDptName { get; set; }

    public string? InitDptShtName { get; set; }

    public int? InitSxnId { get; set; }

    public string? InitSxnName { get; set; }

    public string? InitSxnShtName { get; set; }

    public int? InitLocId { get; set; }

    public string? InitLocName { get; set; }

    public string? InitLocShtName { get; set; }

    public int? InitJbtId { get; set; }

    public string? InitJbtName { get; set; }

    public string? InitJbtShtName { get; set; }

    public string? InitMobNox { get; set; }

    public string? InitEmpName16 { get; set; }
}
