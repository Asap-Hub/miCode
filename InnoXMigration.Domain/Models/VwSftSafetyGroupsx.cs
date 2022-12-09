using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSftSafetyGroupsx
{
    public int SgpIdpk { get; set; }

    public string? SgpName { get; set; }

    public string? SgpShtName { get; set; }

    public DateTime? SgpDateFormed { get; set; }

    public string SgpCodeName { get; set; } = null!;

    public int SgpLocationIdfk { get; set; }

    public bool SgpActive { get; set; }

    public string SgpRmks { get; set; } = null!;

    public int LocIdpk { get; set; }

    public string LocName { get; set; } = null!;

    public string LocShtName { get; set; } = null!;

    public bool LocActive { get; set; }

    public int AreIdpk { get; set; }

    public string AreName { get; set; } = null!;

    public string AreShtName { get; set; } = null!;

    public int SgpDeptIdfk { get; set; }

    public int SgpCoordinatorEmpIdfk { get; set; }

    public int DptIdpk { get; set; }

    public string DptName { get; set; } = null!;

    public string DptShtName { get; set; } = null!;

    public string DptCode { get; set; } = null!;

    public bool DptActive { get; set; }

    public int CoordEmpId { get; set; }

    public string CoordStaffNo { get; set; } = null!;

    public string CoordLname { get; set; } = null!;

    public string CoordFname { get; set; } = null!;

    public string CoordOnames { get; set; } = null!;

    public string CoordEmpName { get; set; } = null!;

    public string CoordEmpName1 { get; set; } = null!;

    public string CoordEmpName2 { get; set; } = null!;

    public string CoordEmpName3 { get; set; } = null!;

    public string CoordEmpName4 { get; set; } = null!;

    public string CoordEmpName5 { get; set; } = null!;

    public string CoordEmpName6 { get; set; } = null!;

    public string CoordEmpName7 { get; set; } = null!;

    public string CoordEmpName8 { get; set; } = null!;

    public string CoordEmpName9 { get; set; } = null!;

    public string CoordEmpName10 { get; set; } = null!;

    public string CoordEmpName11 { get; set; } = null!;

    public int CoordDeptId { get; set; }

    public string CoordDeptName { get; set; } = null!;

    public string CoordDeptShtName { get; set; } = null!;

    public int CoordSxnId { get; set; }

    public string CoordSxnName { get; set; } = null!;

    public string CoordSxnShtName { get; set; } = null!;

    public int CoordLocId { get; set; }

    public string CoordLocName { get; set; } = null!;

    public string CoordLocShtName { get; set; } = null!;

    public string CoordMobNox { get; set; } = null!;

    public string CoordIntercom { get; set; } = null!;

    public string CoordMobNo { get; set; } = null!;

    public int CoordJbtId { get; set; }

    public string CoordJbtName { get; set; } = null!;

    public string CoordJbtShtName { get; set; } = null!;

    public short CoordGndId { get; set; }

    public string CoordGndName { get; set; } = null!;

    public string CoordGndShtName { get; set; } = null!;

    public int DirEmpId { get; set; }

    public string DirStaffNo { get; set; } = null!;

    public string DirLname { get; set; } = null!;

    public string DirFname { get; set; } = null!;

    public string DirOnames { get; set; } = null!;

    public string DirEmpName { get; set; } = null!;

    public string DirEmpName1 { get; set; } = null!;

    public string DirEmpName2 { get; set; } = null!;

    public string DirEmpName3 { get; set; } = null!;

    public string DirEmpName4 { get; set; } = null!;

    public string DirEmpName5 { get; set; } = null!;

    public string DirEmpName6 { get; set; } = null!;

    public string DirEmpName7 { get; set; } = null!;

    public string DirEmpName8 { get; set; } = null!;

    public string DirEmpName9 { get; set; } = null!;

    public string DirEmpName10 { get; set; } = null!;

    public string DirEmpName11 { get; set; } = null!;

    public int DirDeptId { get; set; }

    public string DirDeptName { get; set; } = null!;

    public string DirDeptShtName { get; set; } = null!;

    public int DirSxnId { get; set; }

    public string DirSxnName { get; set; } = null!;

    public string DirSxnShtName { get; set; } = null!;

    public int DirLocId { get; set; }

    public string DirLocName { get; set; } = null!;

    public string DirLocShtName { get; set; } = null!;

    public string DirMobNox { get; set; } = null!;

    public string DirIntercom { get; set; } = null!;

    public string DirMobNo { get; set; } = null!;

    public int DirJbtId { get; set; }

    public string DirJbtName { get; set; } = null!;

    public string DirJbtShtName { get; set; } = null!;

    public short DirGndId { get; set; }

    public string DirGndName { get; set; } = null!;

    public string DirGndShtName { get; set; } = null!;

    public int? SgpCreatedBy { get; set; }

    public int? SgpEditedBy { get; set; }

    public int? SgpDirectorEmpIdfk { get; set; }

    public decimal? SgpNoOfAnnualSafetyMeetings { get; set; }

    public decimal? SgpNoOfFirstQuarterSafetyMeetings { get; set; }

    public decimal? SgpNoOfSecondQuarterSafetyMeetings { get; set; }

    public decimal? SgpNoOfThirdQuarterSafetyMeetings { get; set; }

    public decimal? SgpNoOfFourthQuarterSafetyMeetings { get; set; }

    public decimal? SgpMeetingAttendancePassmark { get; set; }

    public decimal? SgpNoOfPassedMeetingAttendance { get; set; }

    public decimal? SgpMinMeetingDuration { get; set; }

    public decimal? SgpMaxMeetingDuration { get; set; }

    public bool? SgpTechnicalGroup { get; set; }

    public DateTime? SgpEndDate { get; set; }
}
