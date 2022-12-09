using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrEmp
{
    public int EmpIdpk { get; set; }

    public string? EmpStaffNo { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpFirstName { get; set; }

    public string? EmpOtherNames { get; set; }

    public string? EmpLegacyName { get; set; }

    public string? EmpInitials { get; set; }

    public string? EmpNickname { get; set; }

    public int? EmpOrgIdfk { get; set; }

    public DateTime? EmpDoB { get; set; }

    public DateTime? EmpHireDate { get; set; }

    public DateTime? EmpLastPromoDate { get; set; }

    public decimal? EmpBasicSalary { get; set; }

    public decimal? EmpAnnualSalary { get; set; }

    public DateTime? EmpTier1EntryDate { get; set; }

    public DateTime? EmpTier2EntryDate { get; set; }

    public DateTime? EmpTier3EntryDate { get; set; }

    public DateTime? EmpTier4EntryDate { get; set; }

    public DateTime? EmpTier1ExitDate { get; set; }

    public DateTime? EmpTier2ExitDate { get; set; }

    public DateTime? EmpTier3ExitDate { get; set; }

    public DateTime? EmpTier4ExitDate { get; set; }

    public string? EmpTelNo { get; set; }

    public string? EmpMobNo { get; set; }

    public string? EmpMobNox { get; set; }

    public bool? EmpHideMobNo { get; set; }

    public string? EmpIntercom { get; set; }

    public string? EmpFax { get; set; }

    public string? EmpHouseNo { get; set; }

    public string? EmpOfficialEmail { get; set; }

    public string? EmpPersonalEmail { get; set; }

    public string? EmpAddress { get; set; }

    public string? EmpSocSecNo { get; set; }

    public string? EmpNationalId { get; set; }

    public int? EmpTitleIdfk { get; set; }

    public int? EmpBranchIdfk { get; set; }

    public int? EmpDeptIdfk { get; set; }

    public int? EmpSectionIdfk { get; set; }

    public int? EmpUnitIdfk { get; set; }

    public int? EmpAreaIdfk { get; set; }

    public int? EmpLocationIdfk { get; set; }

    public int? EmpGradeIdfk { get; set; }

    public int? EmpStepIdfk { get; set; }

    public int? EmpJobIdfk { get; set; }

    public int? EmpJobLevelIdfk { get; set; }

    public int? EmpJobTitleIdfk { get; set; }

    public int? EmpReligionIdfk { get; set; }

    public int? EmpCostCenterIdfk { get; set; }

    public int? EmpAppraisalGroupIdfk { get; set; }

    public int? EmpGenderIdfk { get; set; }

    public int? EmpTerminationReasonIdfk { get; set; }

    public int? EmpAssignmentStatusIdfk { get; set; }

    public int? EmpEmployeeGroupIdfk { get; set; }

    public int? EmpOfficeLocationIdfk { get; set; }

    public int? EmpRoomIdfk { get; set; }

    public string? EmpOrgUnit { get; set; }

    public string? EmpOrgUnitType { get; set; }

    public int? EmpSupervisorEmpIdfk { get; set; }

    public string? EmpSupervisorShtTitle { get; set; }

    public int? EmpManagerEmpIdfk { get; set; }

    public string? EmpManagerShtTitle { get; set; }

    public int? EmpDirectorEmpIdfk { get; set; }

    public string? EmpDirectorShtTitle { get; set; }

    public int? EmpMaritalStatusIdfk { get; set; }

    public int? EmpNationalityIdfk { get; set; }

    public int? EmpHomeTownIdfk { get; set; }

    public int? EmpAssignmentCategoryIdfk { get; set; }

    public int? EmpPersonTypeIdfk { get; set; }

    public int? EmpAgeProfileIdfk { get; set; }

    public int? EmpPassportPictureIdfk { get; set; }

    public int? EmpSignatureIdfk { get; set; }

    public string? EmpFacebookAccount { get; set; }

    public string? EmpLinkedIn { get; set; }

    public string? EmpSkype { get; set; }

    public string? EmpTwitterHanlde { get; set; }

    public bool? EmpVisible { get; set; }

    public bool? EmpIsSupervisor { get; set; }

    public bool? EmpIsManager { get; set; }

    public bool? EmpIsDirector { get; set; }

    public bool? EmpIsCeo { get; set; }

    public bool? EmpIsDeputyCeo { get; set; }

    public bool? EmpIsStaff { get; set; }

    public bool? EmpIsSeniorStaff { get; set; }

    public bool? EmpIsJuniorStaff { get; set; }

    public bool? EmpIsManagementStaff { get; set; }

    public bool? EmpIsServicePerson { get; set; }

    public bool? EmpIsVoluntaryPerson { get; set; }

    public bool? EmpIsDeptSecretary { get; set; }

    public bool? EmpIsSectionSecretary { get; set; }

    public bool? EmpIsOrgAdmin { get; set; }

    public bool? EmpIsDeptAdmin { get; set; }

    public bool? EmpIsSectionAdmin { get; set; }

    public bool? EmpIsUnitAdmin { get; set; }

    public bool? EmpIsBoardMember { get; set; }

    public bool? EmpIsTechnicalStaff { get; set; }

    public bool? EmpIsCoreStaff { get; set; }

    public bool? EmpIsCasualStaff { get; set; }

    public bool? EmpIsRetiree { get; set; }

    public bool? EmpIsDriver { get; set; }

    public bool? EmpShowInTelDirectory { get; set; }

    public bool? EmpShowBirthdayInAnnouncement { get; set; }

    public bool? EmpShowBirthdayInNewsFlash { get; set; }

    public bool? EmpShowWorkAnniversayInNewsFlash { get; set; }

    public bool? EmpShowWorkAnniversaryInNewsflash { get; set; }

    public bool? EmpUpdated { get; set; }

    public bool? EmpActive { get; set; }

    public string? EmpRmks { get; set; }

    public int? EmpCreatedBy { get; set; }

    public int? EmpEditedBy { get; set; }

    public DateTime? EmpCreationDate { get; set; }

    public DateTime? EmpEditedDate { get; set; }
}
