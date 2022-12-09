using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwSftSafetyGroupProperty
{
    public int SgtIdpk { get; set; }

    public int? SgtGroupIdfk { get; set; }

    public DateTime? SgtStartDate { get; set; }

    public DateTime? SgtEndDate { get; set; }

    public int SgtLocationIdfk { get; set; }

    public bool SgtActive { get; set; }

    public string SgtRmks { get; set; } = null!;

    public int LocIdpk { get; set; }

    public string LocName { get; set; } = null!;

    public string LocShtName { get; set; } = null!;

    public bool LocActive { get; set; }

    public int AreIdpk { get; set; }

    public string AreName { get; set; } = null!;

    public string AreShtName { get; set; } = null!;

    public int SgtDeptIdfk { get; set; }

    public int SgtCoordinatorEmpIdfk { get; set; }

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

    public string CoordHrmsName { get; set; } = null!;

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

    public string CoordPlc { get; set; } = null!;

    public string CoordMobNo { get; set; } = null!;

    public int CoordJbtId { get; set; }

    public string CoordJbtName { get; set; } = null!;

    public string CoordJbtShtName { get; set; } = null!;

    public short CoordGndId { get; set; }

    public string CoordGndName { get; set; } = null!;

    public string CoordGndShtName { get; set; } = null!;

    public int AcoordEmpId { get; set; }

    public string AcoordStaffNo { get; set; } = null!;

    public string AcoordLname { get; set; } = null!;

    public string AcoordFname { get; set; } = null!;

    public string AcoordOnames { get; set; } = null!;

    public string AcoordHrmsName { get; set; } = null!;

    public string AcoordEmpName { get; set; } = null!;

    public string AcoordEmpName1 { get; set; } = null!;

    public string AcoordEmpName2 { get; set; } = null!;

    public string AcoordEmpName3 { get; set; } = null!;

    public string AcoordEmpName4 { get; set; } = null!;

    public string AcoordEmpName5 { get; set; } = null!;

    public string AcoordEmpName6 { get; set; } = null!;

    public string AcoordEmpName7 { get; set; } = null!;

    public string AcoordEmpName8 { get; set; } = null!;

    public string AcoordEmpName9 { get; set; } = null!;

    public string AcoordEmpName10 { get; set; } = null!;

    public string AcoordEmpName11 { get; set; } = null!;

    public int AcoordDeptId { get; set; }

    public string AcoordDeptName { get; set; } = null!;

    public string AcoordDeptShtName { get; set; } = null!;

    public int AcoordSxnId { get; set; }

    public string AcoordSxnName { get; set; } = null!;

    public string AcoordSxnShtName { get; set; } = null!;

    public int AcoordLocId { get; set; }

    public string AcoordLocName { get; set; } = null!;

    public string AcoordLocShtName { get; set; } = null!;

    public string AcoordMobNox { get; set; } = null!;

    public string AcoordPlc { get; set; } = null!;

    public string AcoordMobNo { get; set; } = null!;

    public int AcoordJbtId { get; set; }

    public string AcoordJbtName { get; set; } = null!;

    public string AcoordJbtShtName { get; set; } = null!;

    public short AcoordGndId { get; set; }

    public string AcoordGndName { get; set; } = null!;

    public string AcoordGndShtName { get; set; } = null!;

    public int DirEmpId { get; set; }

    public string DirStaffNo { get; set; } = null!;

    public string DirLname { get; set; } = null!;

    public string DirFname { get; set; } = null!;

    public string DirOnames { get; set; } = null!;

    public string DirHrmsName { get; set; } = null!;

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

    public string DirPlc { get; set; } = null!;

    public string DirMobNo { get; set; } = null!;

    public int DirJbtId { get; set; }

    public string DirJbtName { get; set; } = null!;

    public string DirJbtShtName { get; set; } = null!;

    public short DirGndId { get; set; }

    public string DirGndName { get; set; } = null!;

    public string DirGndShtName { get; set; } = null!;

    public int MgrEmpId { get; set; }

    public string MgrStaffNo { get; set; } = null!;

    public string MgrLname { get; set; } = null!;

    public string MgrFname { get; set; } = null!;

    public string MgrOnames { get; set; } = null!;

    public string MgrHrmsName { get; set; } = null!;

    public string MgrEmpName { get; set; } = null!;

    public string MgrEmpName1 { get; set; } = null!;

    public string MgrEmpName2 { get; set; } = null!;

    public string MgrEmpName3 { get; set; } = null!;

    public string MgrEmpName4 { get; set; } = null!;

    public string MgrEmpName5 { get; set; } = null!;

    public string MgrEmpName6 { get; set; } = null!;

    public string MgrEmpName7 { get; set; } = null!;

    public string MgrEmpName8 { get; set; } = null!;

    public string MgrEmpName9 { get; set; } = null!;

    public string MgrEmpName10 { get; set; } = null!;

    public string MgrEmpName11 { get; set; } = null!;

    public int MgrDeptId { get; set; }

    public string MgrDeptName { get; set; } = null!;

    public string MgrDeptShtName { get; set; } = null!;

    public int MgrSxnId { get; set; }

    public string MgrSxnName { get; set; } = null!;

    public string MgrSxnShtName { get; set; } = null!;

    public int MgrLocId { get; set; }

    public string MgrLocName { get; set; } = null!;

    public string MgrLocShtName { get; set; } = null!;

    public string MgrMobNox { get; set; } = null!;

    public string MgrPlc { get; set; } = null!;

    public string MgrMobNo { get; set; } = null!;

    public int MgrJbtId { get; set; }

    public string MgrJbtName { get; set; } = null!;

    public string MgrJbtShtName { get; set; } = null!;

    public short MgrGndId { get; set; }

    public string MgrGndName { get; set; } = null!;

    public string MgrGndShtName { get; set; } = null!;

    public int ChairEmpId { get; set; }

    public string ChairStaffNo { get; set; } = null!;

    public string ChairLname { get; set; } = null!;

    public string ChairFname { get; set; } = null!;

    public string ChairOnames { get; set; } = null!;

    public string ChairHrmsName { get; set; } = null!;

    public string ChairEmpName { get; set; } = null!;

    public string ChairEmpName1 { get; set; } = null!;

    public string ChairEmpName2 { get; set; } = null!;

    public string ChairEmpName3 { get; set; } = null!;

    public string ChairEmpName4 { get; set; } = null!;

    public string ChairEmpName5 { get; set; } = null!;

    public string ChairEmpName6 { get; set; } = null!;

    public string ChairEmpName7 { get; set; } = null!;

    public string ChairEmpName8 { get; set; } = null!;

    public string ChairEmpName9 { get; set; } = null!;

    public string ChairEmpName10 { get; set; } = null!;

    public string ChairEmpName11 { get; set; } = null!;

    public int ChairDeptId { get; set; }

    public string ChairDeptName { get; set; } = null!;

    public string ChairDeptShtName { get; set; } = null!;

    public int ChairSxnId { get; set; }

    public string ChairSxnName { get; set; } = null!;

    public string ChairSxnShtName { get; set; } = null!;

    public int ChairLocId { get; set; }

    public string ChairLocName { get; set; } = null!;

    public string ChairLocShtName { get; set; } = null!;

    public string ChairMobNox { get; set; } = null!;

    public string ChairPlc { get; set; } = null!;

    public string ChairMobNo { get; set; } = null!;

    public int ChairJbtId { get; set; }

    public string ChairJbtName { get; set; } = null!;

    public string ChairJbtShtName { get; set; } = null!;

    public short ChairGndId { get; set; }

    public string ChairGndName { get; set; } = null!;

    public string ChairGndShtName { get; set; } = null!;

    public int? SgtCreatedBy { get; set; }

    public int? SgtEditedBy { get; set; }

    public int? SgtDirectorEmpIdfk { get; set; }

    public int SgpIdpk { get; set; }

    public string? SgpName { get; set; }

    public string? SgpShtName { get; set; }

    public DateTime? SgpDateFormed { get; set; }

    public DateTime? SgpEndDate { get; set; }

    public string? SgpCodeName { get; set; }

    public bool? SgpTechnicalGroup { get; set; }

    public bool? SgpActive { get; set; }

    public string? SgpRmks { get; set; }

    public int SgtNoOfAnnualSafetyMeetings { get; set; }

    public int SgtNoOfAnnualCompulsaryMeetingAttendance { get; set; }

    public int SgtNoOfFirstQuarterSafetyMeetings { get; set; }

    public int SgtNoOfSecondQuarterSafetyMeetings { get; set; }

    public int? SgtNoOfThirdQuarterSafetyMeetings { get; set; }

    public int? SgtNoOfFourthQuarterSafetyMeetings { get; set; }

    public int? SgtMinMeetingDuration { get; set; }

    public int? SgtMaxMeetingDuration { get; set; }

    public int? SgtAssistantCoordinatorEmpIdfk { get; set; }

    public bool SgpSafetyGroup { get; set; }

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
}
