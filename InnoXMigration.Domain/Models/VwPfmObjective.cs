using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwPfmObjective
{
    public int ObjIdpk { get; set; }

    public int? ObjMissionIdfk { get; set; }

    public string? ObjThemeIdfk { get; set; }

    public string? ObjPerspectiveIdfk { get; set; }

    public string? ObjOwnerEmpIdfk { get; set; }

    public string? ObjName { get; set; }

    public byte? ObjOrder { get; set; }

    public bool? ObjActive { get; set; }

    public string? ObjRmks { get; set; }

    public int PtvIdpk { get; set; }

    public string PtvName { get; set; } = null!;

    public string PtvShtName { get; set; } = null!;

    public string PtvQuestionsAnswered { get; set; } = null!;

    public bool PtvActive { get; set; }

    public string PtvRmks { get; set; } = null!;

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

    public string OwnerAscShtName { get; set; } = null!;

    public int OwnerJbtId { get; set; }

    public string OwnerJbtName { get; set; } = null!;

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

    public string OwnerIntercom { get; set; } = null!;

    public string OwnerOfficialEmail { get; set; } = null!;

    public string OwnerPersonalEmail { get; set; } = null!;

    public DateTime? OwnerHireDate { get; set; }

    public string OwnerJobName { get; set; } = null!;

    public string OwnerJobShtName { get; set; } = null!;

    public string OwnerTelNo { get; set; } = null!;

    public string OwnerMobNo { get; set; } = null!;

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

    public string Expr1 { get; set; } = null!;

    public string ThmCommentary { get; set; } = null!;

    public string ObjDescription { get; set; } = null!;

    public string ObjOutcome { get; set; } = null!;

    public string? ObjShtName { get; set; }
}
