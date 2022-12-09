using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwGenLogger
{
    public int LgrIdpk { get; set; }

    public int? LgrPickedByEmpIdfk { get; set; }

    public int LgrReturnedByEmpIdfk { get; set; }

    public string LgrCategory { get; set; } = null!;

    public DateTime? LgrTimeIn { get; set; }

    public DateTime LgrTimeOut { get; set; }

    public string LgrSignInDescription { get; set; } = null!;

    public string LgrSignOutRemarks { get; set; } = null!;

    public bool LgrSignedIn { get; set; }

    public bool LgrSignedOut { get; set; }

    public bool LgrActive { get; set; }

    public string LgrRmksSignIn { get; set; } = null!;

    public string LgrRmksSignOut { get; set; } = null!;

    public int LgcIdpk { get; set; }

    public string? LgcName { get; set; }

    public string? LgcShtName { get; set; }

    public bool? LgcActive { get; set; }

    public int? LgrCreatedBy { get; set; }

    public int PickedByEmpId { get; set; }

    public string? PickedByStaffNo { get; set; }

    public string? PickedByLname { get; set; }

    public string? PickedByFname { get; set; }

    public string PickedByOnames { get; set; } = null!;

    public string? PickedByEmpName { get; set; }

    public string? PickedByEmpName1 { get; set; }

    public string? PickedByEmpName2 { get; set; }

    public string? PickedByEmpName3 { get; set; }

    public string? PickedByEmpName4 { get; set; }

    public string? PickedByEmpName5 { get; set; }

    public string? PickedByEmpName6 { get; set; }

    public string? PickedByEmpName7 { get; set; }

    public string? PickedByEmpName8 { get; set; }

    public string? PickedByEmpName9 { get; set; }

    public string? PickedByEmpName10 { get; set; }

    public string? PickedByEmpName11 { get; set; }

    public int PickedByStpIdpk { get; set; }

    public string PickedByStpName { get; set; } = null!;

    public string PickedByStpShtName { get; set; } = null!;

    public short PickedByGndIdpk { get; set; }

    public string PickedByGndName { get; set; } = null!;

    public string PickedByGndShtName { get; set; } = null!;

    public int PickedByGrdIdpk { get; set; }

    public string PickedByGrdName { get; set; } = null!;

    public string PickedByGrdShtName { get; set; } = null!;

    public int PickedByDptIdpk { get; set; }

    public string PickedByDptName { get; set; } = null!;

    public string PickedByDptShtName { get; set; } = null!;

    public int PickedBySxnIdpk { get; set; }

    public string PickedBySxnName { get; set; } = null!;

    public string PickedBySxnShtName { get; set; } = null!;

    public int PickedByUntIdpk { get; set; }

    public string PickedByUntName { get; set; } = null!;

    public string PickedByUntShtName { get; set; } = null!;

    public int PickedByLocIdpk { get; set; }

    public string PickedByLocName { get; set; } = null!;

    public string PickedByLocShtName { get; set; } = null!;

    public string PickedByDirTelNo { get; set; } = null!;

    public string PickedByMobNo { get; set; } = null!;

    public string PickedByPlc { get; set; } = null!;

    public string PickedByEmailOff { get; set; } = null!;

    public string PickedByEmailPers { get; set; } = null!;

    public DateTime? PickedByHireDate { get; set; }

    public int PickedByJobIdpk { get; set; }

    public string PickedByJobName { get; set; } = null!;

    public string PickedByJobShtName { get; set; } = null!;

    public string PickedByJobTitle { get; set; } = null!;

    public string? PickedByRptJobTitle { get; set; }

    public int PickedByPstIdpk { get; set; }

    public string PickedByPstName { get; set; } = null!;

    public string PickedByPstShtName { get; set; } = null!;

    public int PickedByAscIdpk { get; set; }

    public string PickedByAscName { get; set; } = null!;

    public string PickedByAscShtName { get; set; } = null!;

    public int PickedByJbtIdpk { get; set; }

    public string PickedByJbtName { get; set; } = null!;

    public string PickedByJbtShtName { get; set; } = null!;

    public string PickedByAddress { get; set; } = null!;

    public string PickedBySsno { get; set; } = null!;

    public string PickedByCostCenter { get; set; } = null!;

    public int PickedByOfcIdpk { get; set; }

    public string PickedByOfcName { get; set; } = null!;

    public string PickedByOfcShtName { get; set; } = null!;

    public int PickedByRomIdpk { get; set; }

    public string PickedByRomName { get; set; } = null!;

    public string PickedByRomShtName { get; set; } = null!;

    public string PickedByResidenceNo { get; set; } = null!;

    public bool PickedByIsDirector { get; set; }

    public bool PickedByIsManager { get; set; }

    public bool PickedByIsSupervisor { get; set; }

    public bool PickedByIsStaff { get; set; }

    public bool PickedByIsSeniorStaff { get; set; }

    public bool PickedByIsJuniorStaff { get; set; }

    public bool PickedByIsManagementStaff { get; set; }

    public bool PickedByIsServicePerson { get; set; }

    public bool PickedByIsVoluntaryPerson { get; set; }

    public string PickedByMobNox { get; set; } = null!;

    public bool PickedByHideMobNo { get; set; }

    public int ReturnedByEmpId { get; set; }

    public string ReturnedByStaffNo { get; set; } = null!;

    public string ReturnedByLname { get; set; } = null!;

    public string ReturnedByFname { get; set; } = null!;

    public string ReturnedByOnames { get; set; } = null!;

    public string ReturnedByEmpName { get; set; } = null!;

    public string ReturnedByEmpName1 { get; set; } = null!;

    public string ReturnedByEmpName2 { get; set; } = null!;

    public string ReturnedByEmpName3 { get; set; } = null!;

    public string? ReturnedByEmpName4 { get; set; }

    public string ReturnedByEmpName5 { get; set; } = null!;

    public string ReturnedByEmpName6 { get; set; } = null!;

    public string ReturnedByEmpName7 { get; set; } = null!;

    public string ReturnedByEmpName8 { get; set; } = null!;

    public string ReturnedByEmpName9 { get; set; } = null!;

    public string ReturnedByEmpName10 { get; set; } = null!;

    public string ReturnedByEmpName11 { get; set; } = null!;

    public int ReturnedByStpIdpk { get; set; }

    public string ReturnedByStpName { get; set; } = null!;

    public string ReturnedByStpShtName { get; set; } = null!;

    public short ReturnedByGndIdpk { get; set; }

    public string ReturnedByGndName { get; set; } = null!;

    public string ReturnedByGndShtName { get; set; } = null!;

    public int ReturnedByGrdIdpk { get; set; }

    public string ReturnedByGrdName { get; set; } = null!;

    public string ReturnedByGrdShtName { get; set; } = null!;

    public int ReturnedByDptIdpk { get; set; }

    public string ReturnedByDptName { get; set; } = null!;

    public string ReturnedByDptShtName { get; set; } = null!;

    public int ReturnedBySxnIdpk { get; set; }

    public string ReturnedBySxnName { get; set; } = null!;

    public string ReturnedByShtName { get; set; } = null!;

    public int ReturnedByUntIdpk { get; set; }

    public string ReturnedByUntName { get; set; } = null!;

    public string ReturnedByUntShtName { get; set; } = null!;

    public int ReturnedByLocIdpk { get; set; }

    public string ReturnedByLocName { get; set; } = null!;

    public string ReturnedByLocShtName { get; set; } = null!;

    public string ReturnedByDirTelNo { get; set; } = null!;

    public string ReturnedByMobNo { get; set; } = null!;

    public string ReturnedByPlc { get; set; } = null!;

    public string ReturnedByEmailOff { get; set; } = null!;

    public string ReturnedByEmailPers { get; set; } = null!;

    public DateTime ReturnedByHireDate { get; set; }

    public int ReturnedByJobIdpk { get; set; }

    public string ReturnedByJobName { get; set; } = null!;

    public string ReturnedByJobShtName { get; set; } = null!;

    public string ReturnedByJobTitle { get; set; } = null!;

    public string ReturnedByRptJobTitle { get; set; } = null!;

    public int ReturnedByPstIdpk { get; set; }

    public string ReturnedByPstName { get; set; } = null!;

    public string ReturnedByPstShtName { get; set; } = null!;

    public int ReturnedByAscIdpk { get; set; }

    public string ReturnedByAscName { get; set; } = null!;

    public string ReturnedByAscShtName { get; set; } = null!;

    public int ReturnedByJbtIdpk { get; set; }

    public string ReturnedByJbtName { get; set; } = null!;

    public string ReturnedByJbtShtName { get; set; } = null!;

    public string ReturnedByAddress { get; set; } = null!;

    public string ReturnedBySsno { get; set; } = null!;

    public string ReturnedByCostCenter { get; set; } = null!;

    public int ReturnedByOfcIdpk { get; set; }

    public string ReturnedByOfcName { get; set; } = null!;

    public string ReturnedByOfcShtName { get; set; } = null!;

    public int ReturnedByRomIdpk { get; set; }

    public string ReturnedByRomName { get; set; } = null!;

    public string ReturnedByRomShtName { get; set; } = null!;

    public string ReturnedByResidenceNo { get; set; } = null!;

    public bool ReturnedByIsDirector { get; set; }

    public bool ReturnedByIsManager { get; set; }

    public bool ReturnedByIsSupervisor { get; set; }

    public bool ReturnedByIsStaff { get; set; }

    public bool ReturnedByIsSeniorStaff { get; set; }

    public bool ReturnedByIsJuniorStaff { get; set; }

    public bool ReturnedByIsManagementStaff { get; set; }

    public bool ReturnedByIsServicePerson { get; set; }

    public bool ReturnedByIsVoluntaryPerson { get; set; }

    public string ReturnedByMobNox { get; set; } = null!;

    public bool ReturnedByHideMobNo { get; set; }

    public int CreatedByUsaIdpk { get; set; }

    public int? CreatedByEmpIdfk { get; set; }

    public string? CreatedByUsername { get; set; }

    public string? CreatedByStaffNo { get; set; }

    public string? CreatedByEmpName { get; set; }

    public string? CreatedByEmpName1 { get; set; }

    public string? CreatedByEmpName2 { get; set; }

    public string? CreatedByEmpName3 { get; set; }

    public string? CreatedByEmpName4 { get; set; }

    public string? CreatedByFname { get; set; }

    public string? CreatedByLname { get; set; }

    public string? CreatedByOnames { get; set; }

    public int? CreatedByLocIdpk { get; set; }

    public string? CreatedByLocName { get; set; }

    public string CreatedByLocShtName { get; set; } = null!;

    public int? CreatedByDptIdpk { get; set; }

    public string? CreatedByDptName { get; set; }

    public int CreatedBySxnIdpk { get; set; }

    public string CreatedBySxnName { get; set; } = null!;

    public string CreatedBySxnShtName { get; set; } = null!;

    public int? CreatedByStpIdpk { get; set; }

    public string CreatedByDirTelNo { get; set; } = null!;

    public string CreatedByMobNo { get; set; } = null!;

    public string CreatedByPlc { get; set; } = null!;

    public string? CreatedByEmailOff { get; set; }

    public string? CreatedByJobName { get; set; }

    public string? CreatedByJobShtName { get; set; }

    public int CreatedByJbtIdpk { get; set; }

    public string CreatedByJbtName { get; set; } = null!;

    public string CreatedByJbtShtName { get; set; } = null!;

    public DateTime? LgrCreationDate { get; set; }
}
