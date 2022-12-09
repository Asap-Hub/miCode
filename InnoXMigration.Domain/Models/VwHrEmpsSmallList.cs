using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwHrEmpsSmallList
{
    public int EmpIdpk { get; set; }

    public string? EmpStaffNo { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpFirstName { get; set; }

    public string EmpOthernames { get; set; } = null!;

    public string? EmpName { get; set; }

    public string? EmpName1 { get; set; }

    public string? EmpName2 { get; set; }

    public string? EmpName3 { get; set; }

    public string? EmpName4 { get; set; }

    public string? EmpName5 { get; set; }

    public DateTime? EmpDoB { get; set; }

    public DateTime? EmpHireDate { get; set; }

    public DateTime? RetireDate { get; set; }

    public decimal? Age { get; set; }

    public DateTime? BirthDay { get; set; }

    public decimal? TenureLeft { get; set; }

    public decimal? ServiceLenght { get; set; }

    public bool EmpVisible { get; set; }

    public int StpIdpk { get; set; }

    public string StpName { get; set; } = null!;

    public string StpShtName { get; set; } = null!;

    public short GndIdpk { get; set; }

    public string GndName { get; set; } = null!;

    public string GndshtName { get; set; } = null!;

    public int DptIdpk { get; set; }

    public string DptName { get; set; } = null!;

    public string DptShtName { get; set; } = null!;

    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public int UntIdpk { get; set; }

    public string UntName { get; set; } = null!;

    public string UntShtName { get; set; } = null!;

    public int UntSectionIdfk { get; set; }

    public int AreIdpk { get; set; }

    public string AreName { get; set; } = null!;

    public string AreShtName { get; set; } = null!;

    public int TitIdpk { get; set; }

    public string TitName { get; set; } = null!;

    public string TitShtName { get; set; } = null!;

    public int LocIdpk { get; set; }

    public string LocName { get; set; } = null!;

    public string LocShtName { get; set; } = null!;

    public int LocAreaIdfk { get; set; }

    public string EmpTelNo { get; set; } = null!;

    public string EmpMobNo { get; set; } = null!;

    public string EmpMobNox { get; set; } = null!;

    public bool EmpHideMobNo { get; set; }

    public string EmpIntercom { get; set; } = null!;

    public string EmpOfficialEmail { get; set; } = null!;

    public string EmpPersonalEmail { get; set; } = null!;

    public int JobIdpk { get; set; }

    public string JobName { get; set; } = null!;

    public string JobShtName { get; set; } = null!;

    public int JlvIdpk { get; set; }

    public string JlvName { get; set; } = null!;

    public string JlvShtName { get; set; } = null!;

    public string JobTitle { get; set; } = null!;

    public string? RptJobTitle { get; set; }

    public int ApgIdpk { get; set; }

    public string ApgName { get; set; } = null!;

    public string ApgShtName { get; set; } = null!;

    public DateTime EmpLastPromoDate { get; set; }

    public decimal EmplastPromotionDuration { get; set; }

    public int AstIdpk { get; set; }

    public string AstName { get; set; } = null!;

    public string AstShtName { get; set; } = null!;

    public int CtyIdpk { get; set; }

    public string CtyName { get; set; } = null!;

    public string CtyShtName { get; set; } = null!;

    public string CtyNationality { get; set; } = null!;

    public int PstIdpk { get; set; }

    public string PstName { get; set; } = null!;

    public string PstShtName { get; set; } = null!;

    public int AscIdpk { get; set; }

    public string AscName { get; set; } = null!;

    public string AscShtName { get; set; } = null!;

    public int MtsIdpk { get; set; }

    public string MtsName { get; set; } = null!;

    public string MtsShtName { get; set; } = null!;

    public int JbtIdpk { get; set; }

    public string JbtName { get; set; } = null!;

    public string JbtShtName { get; set; } = null!;

    public string EmpAddress { get; set; } = null!;

    public string EmpSocSecNo { get; set; } = null!;

    public int EmpOfficeLocIdfk { get; set; }

    public int EmpRoomIdfk { get; set; }

    public string EmpFax { get; set; } = null!;

    public string EmpResidenceNo { get; set; } = null!;

    public bool EmpShowInTelDirectory { get; set; }

    public int RomIdpk { get; set; }

    public string RomName { get; set; } = null!;

    public string RomShtName { get; set; } = null!;

    public int OfcIdpk { get; set; }

    public string OfcName { get; set; } = null!;

    public string OfcShtName { get; set; } = null!;

    public bool EmpShowBirthdayInNewsFlash { get; set; }

    public string EmpRmks { get; set; } = null!;

    public decimal EmpBasicSalary { get; set; }

    public decimal EmpAnnualSalary { get; set; }

    public bool EmpShowBirthdayInAnnouncement { get; set; }

    public bool EmpShowWorkAnniversaryInNewsflash { get; set; }

    public int EmpSupEmpId { get; set; }

    public string EmpSupStaffNo { get; set; } = null!;

    public string EmpSupLastname { get; set; } = null!;

    public string EmpSupFirstname { get; set; } = null!;

    public string? EmpSupName { get; set; }

    public string? EmpSupName16 { get; set; }

    public int EmpMgrEmpId { get; set; }

    public string EmpMgrStaffNo { get; set; } = null!;

    public string EmpMgrLastname { get; set; } = null!;

    public string EmpMgrFirstname { get; set; } = null!;

    public string? EmpMgrName { get; set; }

    public string? EmpMgrName16 { get; set; }

    public int EmpDirEmpId { get; set; }

    public string EmpDirStaffNo { get; set; } = null!;

    public string EmpDirLastname { get; set; } = null!;

    public string EmpDirFirstname { get; set; } = null!;

    public string? EmpDirName { get; set; }

    public int GrdIdpk { get; set; }

    public string GrdName { get; set; } = null!;

    public string GrdShtName { get; set; } = null!;

    public int EgpIdpk { get; set; }

    public string EgpName { get; set; } = null!;

    public string EgpShtName { get; set; } = null!;

    public bool EmpIsCeo { get; set; }

    public bool EmpIsOrgAdmin { get; set; }

    public bool EmpIsUnitAdmin { get; set; }

    public bool EmpIsDeputyCeo { get; set; }

    public bool EmpIsDriver { get; set; }

    public bool EmpIsDirector { get; set; }

    public bool EmpIsManager { get; set; }

    public bool EmpIsSupervisor { get; set; }

    public bool EmpIsStaff { get; set; }

    public bool EmpIsSeniorStaff { get; set; }

    public bool EmpIsJuniorStaff { get; set; }

    public bool EmpIsManagementStaff { get; set; }

    public bool EmpIsServicePerson { get; set; }

    public bool EmpIsVoluntaryPerson { get; set; }

    public bool EmpIsDeptSecretary { get; set; }

    public bool EmpIsSectionSecretary { get; set; }

    public bool EmpIsDeptAdmin { get; set; }

    public bool EmpIsSectionAdmin { get; set; }

    public bool EmpIsBoardMember { get; set; }

    public bool EmpIsTechnicalStaff { get; set; }

    public bool EmpIsCoreStaff { get; set; }

    public bool EmpIsCasualStaff { get; set; }

    public bool EmpIsRetiree { get; set; }

    public int EmpBranchIdfk { get; set; }

    public int ObrIdpk { get; set; }

    public string ObrName { get; set; } = null!;

    public string ObrShtName { get; set; } = null!;

    public string ObrCode { get; set; } = null!;

    public DateTime? ObrStartDate { get; set; }

    public DateTime? ObrEndDate { get; set; }

    public int EmpCostCenterIdfk { get; set; }

    public int CctIdpk { get; set; }

    public string CctName { get; set; } = null!;

    public string CctShtName { get; set; } = null!;

    public string CctCode { get; set; } = null!;

    public string? EmpName18 { get; set; }

    public string? EmpName19 { get; set; }
}
