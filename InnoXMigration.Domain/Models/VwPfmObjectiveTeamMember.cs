using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwPfmObjectiveTeamMember
{
    public int OtmIdpk { get; set; }

    public int? OtmObjectiveIdfk { get; set; }

    public int? OtmEmpIdfk { get; set; }

    public string? OtmStartDate { get; set; }

    public string? OtmEndDate { get; set; }

    public bool? OtmActive { get; set; }

    public string? OtmRmks { get; set; }

    public string? OtmCreatedBy { get; set; }

    public int? OtmEditedBy { get; set; }

    public DateTime? OtmCreationDate { get; set; }

    public DateTime? OtmEditedDate { get; set; }

    public int ObjIdpk { get; set; }

    public int? ObjMissionIdfk { get; set; }

    public string? ObjThemeIdfk { get; set; }

    public string? ObjPerspectiveIdfk { get; set; }

    public string? ObjOwnerEmpIdfk { get; set; }

    public string? ObjObjective { get; set; }

    public byte? ObjOrder { get; set; }

    public bool? ObjActive { get; set; }

    public string? ObjRmks { get; set; }

    public int PtvIdpk { get; set; }

    public string PtvName { get; set; } = null!;

    public string PtvShtName { get; set; } = null!;

    public string PtvQuestionsAnswered { get; set; } = null!;

    public bool PtvActive { get; set; }

    public string PtvRmks { get; set; } = null!;

    public int ThmIdpk { get; set; }

    public int ThmMissionIdfk { get; set; }

    public string ThmName { get; set; } = null!;

    public bool ThmActive { get; set; }

    public string ThmRmks { get; set; } = null!;

    public int MvsIdpk { get; set; }

    public string MvsName { get; set; } = null!;

    public DateTime? MvsStartDate { get; set; }

    public DateTime? MvsEndDate { get; set; }

    public string MvsMission { get; set; } = null!;

    public string MvsMissionSht { get; set; } = null!;

    public string MvsVision { get; set; } = null!;

    public string MvsVisionSht { get; set; } = null!;

    public bool MvsActive { get; set; }

    public byte ThmOrder { get; set; }

    public string ObjObjectiveSht { get; set; } = null!;

    public int OwnerEmpId { get; set; }

    public string OwnerStaffNo { get; set; } = null!;

    public string OwnerLastName { get; set; } = null!;

    public string OwnerFirstName { get; set; } = null!;

    public string OwnerOtherNames { get; set; } = null!;

    public string OwnerEmpName { get; set; } = null!;

    public string OwnerEmpName1 { get; set; } = null!;

    public string OwnerEmpName2 { get; set; } = null!;

    public string OwnerEmpName3 { get; set; } = null!;

    public string OwnerEmpName4 { get; set; } = null!;

    public string OwnerEmpName5 { get; set; } = null!;

    public string OwnerFlnamesNoSpace { get; set; } = null!;

    public string OwnerLfnamesNoSpace { get; set; } = null!;

    public string OwnerLfonamesNoSpace { get; set; } = null!;

    public DateTime? OwnerRetireDate { get; set; }

    public string OwnerStpName { get; set; } = null!;

    public string OwnerStpShtName { get; set; } = null!;

    public short OwnerGndId { get; set; }

    public string OwnerGndName { get; set; } = null!;

    public int OwnerGrdId { get; set; }

    public string OwnerGrdName { get; set; } = null!;

    public string OwnerGrdShtName { get; set; } = null!;

    public int OwnerDptId { get; set; }

    public string OwnerDptName { get; set; } = null!;

    public string OwnerDptShtName { get; set; } = null!;

    public int OwnerSxnId { get; set; }

    public string OwnerSxnName { get; set; } = null!;

    public string OwnerSxnShtName { get; set; } = null!;

    public int OwnerUntId { get; set; }

    public string OwnerUntName { get; set; } = null!;

    public string OwnerUntShtName { get; set; } = null!;

    public int OwnerTitId { get; set; }

    public string OwnerTitName { get; set; } = null!;

    public int OwnerLocId { get; set; }

    public string OwnerLocName { get; set; } = null!;

    public string OwnerLocShtName { get; set; } = null!;

    public int OwnerAscId { get; set; }

    public string OwnerAscName { get; set; } = null!;

    public string OwnerJbtName { get; set; } = null!;

    public string OwnerAscShtName { get; set; } = null!;

    public int OwnerJbtId { get; set; }

    public string OwnerJbtShtName { get; set; } = null!;

    public string OwnerMobNox { get; set; } = null!;

    public int OwnerSupEmpId { get; set; }

    public string OwnerSupStaffNo { get; set; } = null!;

    public string OwnerSupLname { get; set; } = null!;

    public int OwnerOfcId { get; set; }

    public string OwnerOfcName { get; set; } = null!;

    public string OwnerOfcShtName { get; set; } = null!;

    public int OwnerRomId { get; set; }

    public string OwnerRomName { get; set; } = null!;

    public bool OwnerIsDirector { get; set; }

    public bool OwnerIsManager { get; set; }

    public bool OwnerIsSupervisor { get; set; }

    public bool OwnerIsStaff { get; set; }

    public bool OwnerIsSeniorStaff { get; set; }

    public bool OwnerIsJuniorStaff { get; set; }

    public bool OwnerIsManagementStaff { get; set; }

    public bool OwnerIsServicePerson { get; set; }

    public bool OwnerIsVoluntaryPerson { get; set; }

    public string OwnerOfficialEmail { get; set; } = null!;

    public string OwnerPersonalEmail { get; set; } = null!;

    public DateTime? OwnerHireDate { get; set; }

    public string OwnerJobName { get; set; } = null!;

    public string OwnerJobShtName { get; set; } = null!;

    public string OwnerTelNo { get; set; } = null!;

    public string OwnerMobNo { get; set; } = null!;

    public int MemberEmpId { get; set; }

    public string? MemberStaffNo { get; set; }

    public string? MemberLname { get; set; }

    public string? MemberFname { get; set; }

    public string MemberOnames { get; set; } = null!;

    public string MemberHrmsName { get; set; } = null!;

    public string? MemberEmpName { get; set; }

    public string? MemberEmpName1 { get; set; }

    public string? MemberEmpName2 { get; set; }

    public string? MemberEmpName3 { get; set; }

    public string? MemberEmpName4 { get; set; }

    public string? MemberEmpName5 { get; set; }

    public string? MemberFlnamesNoSpace { get; set; }

    public string? MemberLfnamesNoSpace { get; set; }

    public string? MemberLfonamesNoSpace { get; set; }

    public DateTime? MemberRetireDate { get; set; }

    public string MemberStpName { get; set; } = null!;

    public string MemberStpShtName { get; set; } = null!;

    public short MemberGndId { get; set; }

    public string MemberGndName { get; set; } = null!;

    public int MemberGrdId { get; set; }

    public string MemberGrdName { get; set; } = null!;

    public string MemberGrdShtName { get; set; } = null!;

    public int MemberDptId { get; set; }

    public string MemberDptName { get; set; } = null!;

    public string MemberDptShtName { get; set; } = null!;

    public int MemberSxnId { get; set; }

    public string MemberSxnName { get; set; } = null!;

    public string MemberSxnShtName { get; set; } = null!;

    public int MemberUntId { get; set; }

    public string MemberUntName { get; set; } = null!;

    public string MemberUntShtName { get; set; } = null!;

    public int MemberTitId { get; set; }

    public string MemberTitName { get; set; } = null!;

    public int MemberLocId { get; set; }

    public string MemberLocName { get; set; } = null!;

    public string MemberLocShtName { get; set; } = null!;

    public int MemberAscId { get; set; }

    public string MemberAscName { get; set; } = null!;

    public string MemberAscShtName { get; set; } = null!;

    public int MemberJbtId { get; set; }

    public string MemberJbtName { get; set; } = null!;

    public string MemberJbtShtName { get; set; } = null!;

    public string MemberMobNox { get; set; } = null!;

    public int MemberSupEmpId { get; set; }

    public string MemberSupStaffNo { get; set; } = null!;

    public string MemberSupLname { get; set; } = null!;

    public int MemberOfcId { get; set; }

    public string MemberOfcName { get; set; } = null!;

    public string MemberOfcShtName { get; set; } = null!;

    public int MemberRomId { get; set; }

    public string MemberRomName { get; set; } = null!;

    public bool MemberIsDirector { get; set; }

    public bool MemberIsManager { get; set; }

    public bool MemberIsSupervisor { get; set; }

    public bool MemberIsStaff { get; set; }

    public bool MemberIsSeniorStaff { get; set; }

    public bool MemberIsJuniorStaff { get; set; }

    public bool MemberIsManagementStaff { get; set; }

    public bool MemberIsServicePerson { get; set; }

    public bool MemberIsVoluntaryPerson { get; set; }

    public string MemberPlc { get; set; } = null!;

    public string MemberEmailOfficial { get; set; } = null!;

    public string MemberEmailPersonal { get; set; } = null!;

    public DateTime? MemberHireDate { get; set; }

    public string MemberJobName { get; set; } = null!;

    public string MemberJobShtName { get; set; } = null!;

    public string MemberDirTelNo { get; set; } = null!;

    public string MemberMobNo { get; set; } = null!;

    public bool OtmOwner { get; set; }

    public bool? Expr1 { get; set; }
}
