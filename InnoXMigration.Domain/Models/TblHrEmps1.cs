using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrEmps1
{
    public int FempIdpk { get; set; }

    public string FempStaffNo { get; set; } = null!;

    public string? FempLname { get; set; }

    public string? FempFname { get; set; }

    public string? FempOnames { get; set; }

    public string? FempHrmsName { get; set; }

    public string? FempGlobalName { get; set; }

    public string? FempLocalName { get; set; }

    public string? FempInitials { get; set; }

    public string? FempNickname { get; set; }

    public DateTime? FempDoB { get; set; }

    public DateTime? FempHireDate { get; set; }

    public DateTime? FempPromoDate { get; set; }

    public decimal? FempBasicSalary { get; set; }

    public decimal? FempAnnualSalary { get; set; }

    public DateTime? FempTier1EntryDate { get; set; }

    public DateTime? FempTier2EntryDate { get; set; }

    public DateTime? FempTier3EntryDate { get; set; }

    public DateTime? FempTier4EntryDate { get; set; }

    public DateTime? FempTier1ExitDate { get; set; }

    public DateTime? FempTier2ExitDate { get; set; }

    public DateTime? FempTier3ExitDate { get; set; }

    public DateTime? FempTier4ExitDate { get; set; }

    public string? FempDirTelNo { get; set; }

    public string? FempMobNo { get; set; }

    public string? FempMobNox { get; set; }

    public bool? FempHideMobNo { get; set; }

    public string? FempPlc { get; set; }

    public string? FempFax { get; set; }

    public string? FempResidenceNo { get; set; }

    public string? FempEmailOff { get; set; }

    public string? FempEmailPers { get; set; }

    public string? FempAddress { get; set; }

    public string? FempSsno { get; set; }

    public string? FempNationalIdNo { get; set; }

    public string? FempSupervisor { get; set; }

    public string? FempCostCenter { get; set; }

    public int? FempSupervisorEmpIdfk { get; set; }

    public int? FempManagerEmpIdfk { get; set; }

    public int? FempDirectorEmpIdfk { get; set; }

    public byte[]? FempPicx { get; set; }

    public int? FempPicsIdfk { get; set; }

    public byte[]? FempSign { get; set; }

    public int? FempSignatureIdfk { get; set; }

    public int? FempTitleIdfk { get; set; }

    public string? FempOrgUnit { get; set; }

    public string? FempOrgUnitType { get; set; }

    public string? FempTitleName { get; set; }

    public string? FempTitleShtName { get; set; }

    public int? FempDeptIdfk { get; set; }

    public int? FempSectionIdfk { get; set; }

    public int? FempUnitIdfk { get; set; }

    public int? FempLocIdfk { get; set; }

    public int? FempAreaIdfk { get; set; }

    public int? FempGradeIdfk { get; set; }

    public int? FempStepIdfk { get; set; }

    public int? FempJobIdfk { get; set; }

    public int? FempJobLevIdfk { get; set; }

    public int? FempJobTitleIdfk { get; set; }

    public int? FempReligionIdfk { get; set; }

    public int? FempAppraisalGrpIdfk { get; set; }

    public int? FempGenderIdfk { get; set; }

    public int? FempTermReasonIdfk { get; set; }

    public int? FempAssignStatusIdfk { get; set; }

    public int? FempEmployeeGroupIdfk { get; set; }

    public int? FempOfficeLocIdfk { get; set; }

    public int? FempRoomIdfk { get; set; }

    public int? FempSupervisorIdfk { get; set; }

    public int? FempMaritalStatusIdfk { get; set; }

    public int? FempNationalityIdfk { get; set; }

    public int? FempHomeTownIdfk { get; set; }

    public int? FempAssignCatIdfk { get; set; }

    public int? FempPersonTypeIdfk { get; set; }

    public int? FempAgeProfileIdfk { get; set; }

    public string? FempFacebookAccount { get; set; }

    public string? FempLinkedIn { get; set; }

    public string? FempSkype { get; set; }

    public string? FempTwitterHanlde { get; set; }

    public bool? FempVisible { get; set; }

    public bool? FempIsCeo { get; set; }

    public bool? FempIsDirector { get; set; }

    public bool? FempIsManager { get; set; }

    public bool? FempIsSupervisor { get; set; }

    public bool? FempIsStaff { get; set; }

    public bool? FempIsSeniorStaff { get; set; }

    public bool? FempIsJuniorStaff { get; set; }

    public bool? FempIsManagementStaff { get; set; }

    public bool? FempIsServicePerson { get; set; }

    public bool? FempIsVoluntaryPerson { get; set; }

    public bool? FempIsDeptSecretary { get; set; }

    public bool? FempIsSectionalSecretary { get; set; }

    public bool? FempIsDeptAdministrator { get; set; }

    public bool? FempIsSectionalAdministrator { get; set; }

    public bool? FempIsBoardMember { get; set; }

    public bool? FempIsTechnicalStaff { get; set; }

    public bool? FempIsCoreStaff { get; set; }

    public bool? FempIsCasualStaff { get; set; }

    public bool? FempIsRetiree { get; set; }

    public bool? FempIsDriver { get; set; }

    public bool? FempShowInTelDirectory { get; set; }

    public bool? FempShowBirthdayInNewsFlash { get; set; }

    public bool? FempShowBirthdayInAnnouncement { get; set; }

    public bool? FempShowWorkAnniversaryInNewsflash { get; set; }

    public bool? FempActive { get; set; }

    public string? FempRmks { get; set; }

    public int? FempCreatedBy { get; set; }

    public int? FempEditedBy { get; set; }

    public DateTime? FempCreationDate { get; set; }

    public DateTime? FempEditedDate { get; set; }
}
