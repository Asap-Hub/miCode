using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwGenUsersAllPrivilege
{
    public int UsaIdpk { get; set; }

    public string? EmpStaffNo { get; set; }

    public int? UsaEmpIdfk { get; set; }

    public string? UsaUsername { get; set; }

    public string? UsaPassword { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpOthernames { get; set; }

    public string? EmpName { get; set; }

    public string? EmpName1 { get; set; }

    public string? EmpName2 { get; set; }

    public DateTime? EmpDoB { get; set; }

    public bool? EmpVisible { get; set; }

    public int? LocIdpk { get; set; }

    public string? LocName { get; set; }

    public bool? LocActive { get; set; }

    public int? AreIdpk { get; set; }

    public string? AreName { get; set; }

    public bool? AreActive { get; set; }

    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public bool? SxnActive { get; set; }

    public int? DptIdpk { get; set; }

    public string? DptName { get; set; }

    public int? StpIdpk { get; set; }

    public string? StpName { get; set; }

    public bool? StpActive { get; set; }

    public short? GndIdpk { get; set; }

    public string? GndName { get; set; }

    public int? GrdIdpk { get; set; }

    public string? GrdName { get; set; }

    public bool? GrdActive { get; set; }

    public int? TitIdpk { get; set; }

    public string? TitName { get; set; }

    public bool? TitActive { get; set; }

    public int? EmpIdpk { get; set; }

    public bool UsaLoggedIn { get; set; }

    public bool UsaActive { get; set; }

    public string UsaRmks { get; set; } = null!;

    public string GndshtName { get; set; } = null!;

    public string StpShtName { get; set; } = null!;

    public string GrdShtName { get; set; } = null!;

    public string DptShtName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public int UntIdpk { get; set; }

    public string UntName { get; set; } = null!;

    public string UntShtName { get; set; } = null!;

    public string AreShtName { get; set; } = null!;

    public string TitShtName { get; set; } = null!;

    public string LocShtName { get; set; } = null!;

    public string EmpDirTelNo { get; set; } = null!;

    public string EmpMobNo { get; set; } = null!;

    public string EmpIntercom { get; set; } = null!;

    public string? EmpOfficialEmail { get; set; }

    public string? EmpPersonalEmail { get; set; }

    public DateTime? EmpHireDate { get; set; }

    public int? JobIdpk { get; set; }

    public string? JobName { get; set; }

    public string? JobShtName { get; set; }

    public bool? JobActive { get; set; }

    public int? JlvIdpk { get; set; }

    public string? JlvName { get; set; }

    public string? JlvShtName { get; set; }

    public bool UsaSeeAllForms { get; set; }

    public bool UsaSuperUser { get; set; }

    public bool UsaSeeSalaries { get; set; }

    public bool UsaEditEmails { get; set; }

    public string? EmpName3 { get; set; }

    public string? EmpName4 { get; set; }

    public string? EmpFirstName { get; set; }

    public int? UsaDefaultModuleIdfk { get; set; }

    public bool UsaEditIntercom { get; set; }

    public string JobTitle { get; set; } = null!;

    public string RptJobTitle { get; set; } = null!;

    public int JbtIdpk { get; set; }

    public string JbtName { get; set; } = null!;

    public string JbtShtName { get; set; } = null!;

    public bool JbtActive { get; set; }

    public string EmpMobNox { get; set; } = null!;

    public bool EmpHideMobNo { get; set; }

    public bool UsaShowRightNavigatorOnStartup { get; set; }

    public bool EmpActive { get; set; }

    public bool DptActive { get; set; }

    public int AscIdpk { get; set; }

    public string AscName { get; set; } = null!;

    public string AscShtName { get; set; } = null!;

    public string? EmpName5 { get; set; }

    public string? EmpName6 { get; set; }

    public string? EmpName7 { get; set; }

    public string? EmpName8 { get; set; }

    public string? EmpName9 { get; set; }

    public string? EmpName10 { get; set; }

    public string? EmpName11 { get; set; }

    public string? EmpName12 { get; set; }

    public string? EmpName13 { get; set; }

    public string? EmpName14 { get; set; }

    public string? EmpName15 { get; set; }

    public string EmpName16 { get; set; } = null!;

    public bool UsaShowTipOfDayOnStartup { get; set; }

    public bool EmpIsManagementStaff { get; set; }

    public bool EmpIsServicePerson { get; set; }

    public DateTime? UsaCreationDate { get; set; }

    public int? UsaCreatedBy { get; set; }

    public bool UsaAllowSendingOfSms { get; set; }

    public bool UsaSeeExecDashboard { get; set; }

    public DateTime? UsaEndDate { get; set; }

    public bool UsaSeeClassifiedDocs { get; set; }

    public bool UsaSeeAuditTrail { get; set; }

    public bool UsaChangePassword { get; set; }

    public bool UsaEditOthersMobNos { get; set; }

    public bool UsaSeeHiddenMobNos { get; set; }

    public bool UsaStartNewsflashOnStartup { get; set; }

    public bool EmpShowBirthdayInNewsFlash { get; set; }

    public bool EmpShowWorkAnniversaryInNewsflash { get; set; }

    public int ApmIdpk { get; set; }

    public string ApmName { get; set; } = null!;

    public string ApmShtName { get; set; } = null!;

    public bool ApmActive { get; set; }

    public string? ApmCode { get; set; }

    public byte? ApmOrder { get; set; }

    public bool? ApmIsHelpModule { get; set; }

    public byte? ApmHelpModuleOrder { get; set; }

    public bool? ApmIsHelpModuleOnly { get; set; }

    public string EmpTelNo { get; set; } = null!;

    public bool? EmpIsOrgAdmin { get; set; }

    public bool? EmpIsDeptAdmin { get; set; }

    public bool? EmpIsSectionAdmin { get; set; }

    public bool? EmpIsUnitAdmin { get; set; }

    public bool? EmpIsCeo { get; set; }

    public bool? EmpIsDirector { get; set; }

    public bool? EmpIsManager { get; set; }

    public bool? EmpIsSupervisor { get; set; }

    public bool? EmpIsSeniorStaff { get; set; }

    public bool? EmpIsJuniorStaff { get; set; }

    public bool? EmpIsStaff { get; set; }

    public bool PtmSysAdmin { get; set; }

    public bool PtmWorkshopServiceOfficer { get; set; }

    public bool PtmWorkshopServiceSupervisor { get; set; }

    public bool PtmPreparesJobCards { get; set; }

    public bool PtmRecommendsJobCards { get; set; }

    public bool PtmAuthorisesJobCards { get; set; }

    public bool PtmApprovalSupervisor { get; set; }

    public bool PtmApprovalManager { get; set; }

    public bool PtmApprovalDirector { get; set; }

    public bool PtmApprovalCeo1 { get; set; }

    public bool PtmApprovalCeo2 { get; set; }

    public bool PtmSupervisor { get; set; }

    public bool PtmManager { get; set; }

    public bool PtmDirector { get; set; }

    public bool PtmSaveConditionReturns { get; set; }

    public bool PtmSubmitConditionReturns { get; set; }

    public bool PtmFuelAnalyst { get; set; }

    public bool PtmOrgAdmin { get; set; }

    public bool PtmDeptAdmin { get; set; }

    public bool PtmSectionAdmin { get; set; }

    public bool PtmUnitAdmin { get; set; }

    public bool PtmSaveDeptConditionReturns { get; set; }

    public bool PtmSaveSectionConditionReturns { get; set; }

    public bool PtmSubmitDeptConditionReturns { get; set; }

    public bool PtmSubmitSectionConditionReturns { get; set; }

    public bool PtmSeeDriversCodes { get; set; }

    public bool PtmApproveFuelRequests { get; set; }

    public bool PtmRecommendAllVehicleRequests { get; set; }

    public int TblGenPrivilegesSafetyManagement { get; set; }

    public int PsmEmpIdfk { get; set; }

    public bool PsmSysAdmin { get; set; }

    public bool PsmOrgAdmin { get; set; }

    public bool PsmDeptAdmin { get; set; }

    public bool PsmSectionAdmin { get; set; }

    public string PsmUnitAdmin { get; set; } = null!;

    public bool PsmDirector { get; set; }

    public bool PsmManager { get; set; }

    public bool PsmSupervisor { get; set; }

    public bool PsmRecommendTopics { get; set; }

    public bool PsmApproveTopics { get; set; }

    public bool PsmManageCentralPpeStocks { get; set; }

    public bool PsmSignOffCentralPpeStocks { get; set; }

    public int PreEmpIdfk { get; set; }

    public bool PreSupervisor { get; set; }

    public bool PreManager { get; set; }

    public bool PreDirector { get; set; }

    public bool PreCeo { get; set; }

    public bool PreOfficer { get; set; }

    public bool PreFacilitiesServiceSupervisor { get; set; }

    public bool PrePreparesJobCards { get; set; }

    public bool PreRecommendsJobCards { get; set; }

    public bool PreAuthorisesJobCards { get; set; }

    public bool PreApprovalSupervisor { get; set; }

    public bool PreApprovalManager { get; set; }

    public bool PreApprovalDirector { get; set; }

    public bool PreApprovalCeo1 { get; set; }

    public bool PreApprovalCeo2 { get; set; }

    public bool PreOrgAdmin { get; set; }

    public bool PreDeptAdmin { get; set; }

    public bool PreSectionAdmin { get; set; }

    public bool PreUnitAdmin { get; set; }

    public bool PreAllowBacklogEntry { get; set; }

    public bool PreFacilitiesAdmin { get; set; }

    public bool PreFacilitiesServiceOfficer { get; set; }

    public int PcaIdpk { get; set; }

    public int PcaEmpIdfk { get; set; }

    public bool PcaSupervisor { get; set; }

    public bool PcaManager { get; set; }

    public bool PcaDirector { get; set; }

    public bool PcaClassifyIssues { get; set; }

    public bool PcaAssignRequests { get; set; }

    public bool PcaTechnician { get; set; }

    public bool PcaSysAdmin { get; set; }

    public bool PcaActive { get; set; }

    public int PpmIdpk { get; set; }

    public int PpmEmpIdfk { get; set; }

    public bool PpmDeptAdmin { get; set; }

    public bool PpmSectionAdmin { get; set; }

    public bool PpmUnitAdmin { get; set; }

    public bool UsaNewAccount { get; set; }

    public bool UsaShowToDoOnStartup { get; set; }

    public bool UsaShowAdvertOnStartup { get; set; }

    public bool UsaResetOthersPasswords { get; set; }

    public string UsaAppTheme { get; set; } = null!;

    public bool UsaShowNewsflashBarOnStartup { get; set; }

    public bool UsaShowWorkAnniversaryInNewsflash { get; set; }

    public bool UsaShowBirthdayInNewsflash { get; set; }

    public bool UsaShowAlertsWindowOnStartup { get; set; }

    public bool UsaShowTaskOnStartup { get; set; }
}
