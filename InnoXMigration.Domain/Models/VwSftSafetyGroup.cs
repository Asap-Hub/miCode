using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSftSafetyGroup
{
    public int SgpIdpk { get; set; }

    public string? SgpName { get; set; }

    public string? SgpShtName { get; set; }

    public DateTime SgpDateFormed { get; set; }

    public string SgpCodeName { get; set; } = null!;

    public int SgpLocationIdfk { get; set; }

    public bool SgpActive { get; set; }

    public string SgpRmks { get; set; } = null!;

    public int SgpDeptIdfk { get; set; }

    public int SgpCoordinatorEmpIdfk { get; set; }

    public int? SgpCreatedBy { get; set; }

    public int SgpEditedBy { get; set; }

    public int SgpDirectorEmpIdfk { get; set; }

    public DateTime SgpEndDate { get; set; }

    public bool SgpTechnicalGroup { get; set; }

    public int SgtIdpk { get; set; }

    public int SgtGroupIdfk { get; set; }

    public DateTime SgtStartDate { get; set; }

    public DateTime SgtEndDate { get; set; }

    public bool SgtActive { get; set; }

    public int CoordEmpId { get; set; }

    public string CoordStaffNo { get; set; } = null!;

    public string CoordLname { get; set; } = null!;

    public string CoordFname { get; set; } = null!;

    public string CoordEmpName { get; set; } = null!;

    public string CoordEmpName1 { get; set; } = null!;

    public int CoordDeptId { get; set; }

    public string CoordDeptName { get; set; } = null!;

    public string CoordDeptShtName { get; set; } = null!;

    public int CoordSxnId { get; set; }

    public string CoordSxnName { get; set; } = null!;

    public string CoordSxnShtName { get; set; } = null!;

    public int AcoordEmpId { get; set; }

    public string AcoordStaffNo { get; set; } = null!;

    public string AcoordLname { get; set; } = null!;

    public string AcoordFname { get; set; } = null!;

    public string AcoordEmpName { get; set; } = null!;

    public string AcoordEmpName1 { get; set; } = null!;

    public int AcoordDeptId { get; set; }

    public string AcoordDeptName { get; set; } = null!;

    public string AcoordDeptShtName { get; set; } = null!;

    public int AcoordSxnId { get; set; }

    public string AcoordSxnName { get; set; } = null!;

    public string AcoordSxnShtName { get; set; } = null!;

    public string AcoordMobNox { get; set; } = null!;

    public string AcoordPlc { get; set; } = null!;

    public string AcoordMobNo { get; set; } = null!;

    public int DirEmpId { get; set; }

    public string DirStaffNo { get; set; } = null!;

    public string DirLname { get; set; } = null!;

    public string DirFname { get; set; } = null!;

    public string DirEmpName { get; set; } = null!;

    public string DirEmpName1 { get; set; } = null!;

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

    public string DirPlc { get; set; } = null!;

    public string DirMobNo { get; set; } = null!;

    public int DirJbtId { get; set; }

    public string DirJbtName { get; set; } = null!;

    public string DirJbtShtName { get; set; } = null!;

    public int MgrEmpId { get; set; }

    public string MgrStaffNo { get; set; } = null!;

    public string MgrLname { get; set; } = null!;

    public string MgrFname { get; set; } = null!;

    public string MgrEmpName { get; set; } = null!;

    public string MgrEmpName1 { get; set; } = null!;

    public int MgrDeptId { get; set; }

    public string MgrDeptName { get; set; } = null!;

    public string MgrDeptShtName { get; set; } = null!;

    public int MgrSxnId { get; set; }

    public string MgrSxnName { get; set; } = null!;

    public string MgrSxnShtName { get; set; } = null!;

    public string MgrMobNox { get; set; } = null!;

    public string MgrPlc { get; set; } = null!;

    public string MgrMobNo { get; set; } = null!;

    public int ChairEmpId { get; set; }

    public string ChairStaffNo { get; set; } = null!;

    public string ChairLname { get; set; } = null!;

    public string ChairFname { get; set; } = null!;

    public string ChairEmpName { get; set; } = null!;

    public string ChairEmpName1 { get; set; } = null!;

    public int ChairDeptId { get; set; }

    public string ChairDeptName { get; set; } = null!;

    public string ChairDeptShtName { get; set; } = null!;

    public int ChairSxnId { get; set; }

    public string ChairSxnName { get; set; } = null!;

    public string ChairSxnShtName { get; set; } = null!;

    public string ChairMobNox { get; set; } = null!;

    public string ChairPlc { get; set; } = null!;

    public string ChairMobNo { get; set; } = null!;

    public int ChairJbtId { get; set; }

    public string ChairJbtName { get; set; } = null!;

    public string ChairJbtShtName { get; set; } = null!;

    public int SgtNoOfAnnualSafetyMeetings { get; set; }

    public int SgtNoOfAnnualCompulsaryMeetingAttendance { get; set; }

    public int SgtNoOfFirstQuarterSafetyMeetings { get; set; }

    public int SgtNoOfSecondQuarterSafetyMeetings { get; set; }

    public int SgtNoOfThirdQuarterSafetyMeetings { get; set; }

    public int SgtNoOfFourthQuarterSafetyMeetings { get; set; }

    public int SgtMinMeetingDuration { get; set; }

    public int SgtMaxMeetingDuration { get; set; }

    public string CoordMobNox { get; set; } = null!;

    public string CoordPlc { get; set; } = null!;

    public string CoordMobNo { get; set; } = null!;

    public int CoordJbtId { get; set; }

    public string CoordJbtName { get; set; } = null!;

    public string CoordJbtShtName { get; set; } = null!;

    public int AcoordJbtId { get; set; }

    public string AcoordJbtName { get; set; } = null!;

    public string AcoordJbtShtName { get; set; } = null!;

    public int MgrJbtId { get; set; }

    public string MgrJbtName { get; set; } = null!;

    public string MgrJbtShtName { get; set; } = null!;

    public short CoordGndId { get; set; }

    public string CoordGndName { get; set; } = null!;

    public string CoordGndShtName { get; set; } = null!;

    public DateTime? SgpCreationDate { get; set; }

    public DateTime? SgpEditedDate { get; set; }

    public bool SgpSafetyGroup { get; set; }

    public bool SgpMasterGroup { get; set; }

    public int GznIdpk { get; set; }

    public string GznName { get; set; } = null!;

    public string GznShtName { get; set; } = null!;

    public int GtmIdpk { get; set; }

    public string GtmName { get; set; } = null!;

    public string GtmShtName { get; set; } = null!;

    public byte? SgtNoOfJanuaryMeetings { get; set; }

    public byte? SgtNoOfFebruaryMeetings { get; set; }

    public byte? SgtNoOfMarchMeetings { get; set; }

    public byte? SgtNoOfAprilMeetings { get; set; }

    public byte? SgtNoOfMayMeetings { get; set; }

    public byte? SgtNoOfJuneMeetings { get; set; }

    public byte? SgtNoOfJulyMeetings { get; set; }

    public byte? SgtNoOfAugustMeetings { get; set; }

    public byte? SgtNoOfSeptemberMeetings { get; set; }

    public byte? SgtNoOfOctoberMeetings { get; set; }

    public byte? SgtNoOfNovemberMeetings { get; set; }

    public byte? SgtNoOfDecemberMeetings { get; set; }

    public bool GtmActive { get; set; }

    public bool SgpSubmitWasacoReturns { get; set; }

    public int? LocIdpk { get; set; }

    public string? LocName { get; set; }

    public string? LocShtName { get; set; }

    public bool? LocActive { get; set; }

    public int? AreIdpk { get; set; }

    public string? AreName { get; set; }

    public string? AreShtName { get; set; }

    public int? DptIdpk { get; set; }

    public string? DptName { get; set; }

    public string? DptShtName { get; set; }

    public bool SgpSendSmsAlertsToMembers { get; set; }
}
