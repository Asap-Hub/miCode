using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenUsersx
{
    public int FusaIdpk { get; set; }

    public int? FusaEmpIdfk { get; set; }

    public string? FusaUsername { get; set; }

    public string? FusaPassword { get; set; }

    public bool? FusaChangePswd { get; set; }

    public bool? FusaLoggedIn { get; set; }

    public bool? FusaSuperUser { get; set; }

    public bool? FusaAllowSendingOfSms { get; set; }

    public bool? FusaIsCeo { get; set; }

    public bool? FusaSeeSalaries { get; set; }

    public bool? FusaEditOthersMobNos { get; set; }

    public bool? FusaSeeHiddenMobNos { get; set; }

    public bool? FusaEditPlc { get; set; }

    public bool? FusaEditEmails { get; set; }

    public int? FusaDefaultModuleIdfk { get; set; }

    public bool? FusaApproveJobDescriptions { get; set; }

    public bool? FusaOrgAdmin { get; set; }

    public bool? FusaDeptAdmin { get; set; }

    public bool? FusaSxnAdmin { get; set; }

    public bool? FusaUnitAdmin { get; set; }

    public bool? FusaShowRightNavigatorOnStartup { get; set; }

    public bool? FusaTransportAdmin { get; set; }

    public bool? FusaTransWorkshopServiceOfficer { get; set; }

    public bool? FusaTransWorkshopServiceSupervisor { get; set; }

    public bool? FusaTransPreparesJobCards { get; set; }

    public bool? FusaTransRecommendsJobCards { get; set; }

    public bool? FusaTransAuthorisesJobCards { get; set; }

    public bool? FusaTransApprovalSupervisor { get; set; }

    public bool? FusaTransApprovalManager { get; set; }

    public bool? FusaTransApprovalDirector { get; set; }

    public bool? FusaTransApprovalCeo1 { get; set; }

    public bool? FusaTransApprovalCeo2 { get; set; }

    public bool? FusaTransSupervisor { get; set; }

    public bool? FusaTransCeo1 { get; set; }

    public bool? FusaTransCeo2 { get; set; }

    public bool? FusaFuelAnalyst { get; set; }

    public bool? FusaRstSupervisor { get; set; }

    public bool? FusaRstManager { get; set; }

    public bool? FusaRstDirector { get; set; }

    public bool? FusaRstCeo { get; set; }

    public bool? FusaRstOfficer { get; set; }

    public bool? FusaTransManager { get; set; }

    public bool? FusaTransDirector { get; set; }

    public bool? FusaTransSaveConditionReturns { get; set; }

    public bool? FusaTransSubmitConditionReturns { get; set; }

    public bool? FusaTransFuelAnalyst { get; set; }

    public bool? FusaTransOrgAdmin { get; set; }

    public bool? FusaTransDeptAdmin { get; set; }

    public bool? FusaTransSectionAdmin { get; set; }

    public bool? FusaTransUnitAdmin { get; set; }

    public bool? FusaTransSaveDeptConditionReturns { get; set; }

    public bool? FusaTransSaveSectionConditionReturns { get; set; }

    public bool? FusaTransSubmitDeptConditionReturns { get; set; }

    public bool? FusaTransSubmitSectionConditionReturns { get; set; }

    public bool? FusaTransSeeDriversCodes { get; set; }

    public bool? FusaTransApproveFuelRequests { get; set; }

    public bool? FusaTransRecommendAllVehicleRequests { get; set; }

    public bool? FusaRstFacilitiesServiceSupervisor { get; set; }

    public bool? FusaRstPreparesJobCards { get; set; }

    public bool? FusaRstRecommendsJobCards { get; set; }

    public bool? FusaRstAuthorisesJobCards { get; set; }

    public bool? FusaRstApprovalSupervisor { get; set; }

    public bool? FusaRstApprovalManager { get; set; }

    public bool? FusaRstApprovalDirector { get; set; }

    public bool? FusaRstApprovalCeo1 { get; set; }

    public bool? FusaRstApprovalCeo2 { get; set; }

    public bool? FusaRstOrgAdmin { get; set; }

    public bool? FusaRstDeptAdmin { get; set; }

    public bool? FusaRstSectionAdmin { get; set; }

    public bool? FusaRstUnitAdmin { get; set; }

    public bool? FusaRstAllowBacklogEntry { get; set; }

    public bool? FusaRstFacilitiesAdmin { get; set; }

    public bool? FusaRstFacilitiesServiceOfficer { get; set; }

    public bool? FusaDeptProjAdmin { get; set; }

    public bool? FusaSectionProjAdmin { get; set; }

    public bool? FusaUnitProjAdmin { get; set; }

    public bool? FusaReviewHrTraining { get; set; }

    public bool? FusaApproveHrTraining { get; set; }

    public bool? FusaEndorseHrTraining { get; set; }

    public bool? FusaSignHrTraining { get; set; }

    public bool? FusaApproveOt { get; set; }

    public bool? FusaReviewOt { get; set; }

    public bool? FusaEndorseOt { get; set; }

    public bool? FusaSignOt { get; set; }

    public bool? FusaReviewRentAdvance { get; set; }

    public bool? FusaApproveRentAdvance { get; set; }

    public bool? FusaEndorseRentAdvance { get; set; }

    public bool? FusaSignRentAdvance { get; set; }

    public bool? FusaReviewCarLoan { get; set; }

    public bool? FusaApproveCarLoan { get; set; }

    public bool? FusaEndorseCarLoan { get; set; }

    public bool? FusaSignCarLoan { get; set; }

    public bool? FusaAnswerQuestions { get; set; }

    public bool? FusaBeneficiaryWitness { get; set; }

    public bool? FusaBeneficiaryApprove { get; set; }

    public bool? FusaBeneficiaryManage { get; set; }

    public bool? FusaBeneficiarySendSms { get; set; }

    public bool? FusaBeneficiarySendSmsToAllStaff { get; set; }

    public DateTime? FusaEndDate { get; set; }

    public bool? FusaActive { get; set; }

    public bool? FusaSeeAllForms { get; set; }

    public bool? FusaNewAccount { get; set; }

    public bool? FusaShowTaskOnStartup { get; set; }

    public bool? FusaShowToDoOnStartup { get; set; }

    public bool? FusaShowAdvertOnStartup { get; set; }

    public bool? FusaShowTipOfDayOnStartup { get; set; }

    public bool? FusaStartNewsflashOnStartup { get; set; }

    public string? FusaFormSkinName { get; set; }

    public bool? FusaExternalSecurity { get; set; }

    public bool? FusaInternalSecurity { get; set; }

    public bool? FusaSecurityDirector { get; set; }

    public bool? FusaSecurityManager { get; set; }

    public bool? FusaSecuritySupervisor { get; set; }

    public bool? FusaSecurityOrgAdmin { get; set; }

    public bool? FusaSafetySysAdmin { get; set; }

    public bool? FusaSafetyOrgAdmin { get; set; }

    public bool? FusaSafetyDeptAdmin { get; set; }

    public bool? FusaSafetySectionAdmin { get; set; }

    public string? FusaSafetyUnitAdmin { get; set; }

    public bool? FusaSafetyDirector { get; set; }

    public bool? FusaSafetyManager { get; set; }

    public bool? FusaSafetySupervisor { get; set; }

    public bool? FusaSafetyRecommendTopics { get; set; }

    public bool? FusaSafetyApproveTopics { get; set; }

    public bool? FusaSafetyManageCentralPpeStocks { get; set; }

    public bool? FusaSafetySignOffCentralPpeStocks { get; set; }

    public bool? FusaVregInspect { get; set; }

    public bool? FusaVregRecommend { get; set; }

    public bool? FusaVregApprove { get; set; }

    public bool? FusaIttechnician { get; set; }

    public bool? FusaItsupervisor { get; set; }

    public bool? FusaItmanager { get; set; }

    public bool? FusaItdirector { get; set; }

    public bool? FusaCamsClassifyIssues { get; set; }

    public bool? FusaCamsAssignItrequests { get; set; }

    public bool? FusaCamsTechnician { get; set; }

    public bool? FusaCamsSupervisor { get; set; }

    public bool? FusaCamsManager { get; set; }

    public bool? FusaCamsDirector { get; set; }

    public bool? FusaCamsSysAdmin { get; set; }

    public bool? FusaCamsAssignRequests { get; set; }

    public bool? FusaCamsAlertsToGroupMembers { get; set; }

    public bool? FusaClassifyIssuesReported { get; set; }

    public bool? FusaAssocMgrAllowSendAlertsToAllStaff { get; set; }

    public bool? FusaAssocMgrAllowSendAlertsToGroupMembers { get; set; }

    public bool? FusaSeeExecDashboard { get; set; }

    public bool? FusaSeeClassifiedDocs { get; set; }

    public bool? FusaSeeAuditTrail { get; set; }

    public bool? FusaResetPasswords { get; set; }

    public bool? FusaApproveSoftwareRequests { get; set; }

    public string? FusaRmks { get; set; }

    public int? FusaCreatedBy { get; set; }

    public int? FusaEditedBy { get; set; }

    public DateTime? FusaCreationDate { get; set; }

    public DateTime? FusaEditedDate { get; set; }

    public bool? FusaUnitOtadmin { get; set; }

    public bool? FusaSectionOtadmin { get; set; }

    public bool? FusaDeptOtadmin { get; set; }

    public bool? FusaOrgOtadmin { get; set; }

    public bool? FusaOtallowUserToChangeOrgx { get; set; }

    public bool? FusaOtallowUserToChangeOrgxx { get; set; }

    public bool? FusaOtallowUserToChangeOrg { get; set; }
}
