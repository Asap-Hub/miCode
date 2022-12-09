using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwTdrTelDirectory
{
    public int TdrIdpk { get; set; }

    public int? EmpIdpk { get; set; }

    public int TdoIdpk { get; set; }

    public int? TdrGroupIdfk { get; set; }

    public int? TdrOtherSourceIdfk { get; set; }

    public int? TdrEmpIdfk { get; set; }

    public int? TdgIdpk { get; set; }

    public string? TdgName { get; set; }

    public string? TdgShtName { get; set; }

    public bool? TdgEmp { get; set; }

    public decimal? TdgOrder { get; set; }

    public bool TdgActive { get; set; }

    public string Empstaffno { get; set; } = null!;

    public string Empname { get; set; } = null!;

    public int FdptIdpk { get; set; }

    public string Dptname { get; set; } = null!;

    public string Dptshtname { get; set; } = null!;

    public int FsxnIdpk { get; set; }

    public string Sxnname { get; set; } = null!;

    public string Sxnshtname { get; set; } = null!;

    public int? AreIdpk { get; set; }

    public string? AreName { get; set; }

    public string? AreShtName { get; set; }

    public int? UntIdpk { get; set; }

    public string? UntName { get; set; }

    public string? UntShtName { get; set; }

    public int? LocIdpk { get; set; }

    public string Locname { get; set; } = null!;

    public string Locshtname { get; set; } = null!;

    public string Empplc { get; set; } = null!;

    public string Empdirtelno { get; set; } = null!;

    public string Empmobno { get; set; } = null!;

    public string Empemailoff { get; set; } = null!;

    public string Empemailpers { get; set; } = null!;

    public string EmpJobTitle { get; set; } = null!;

    public int? OfcIdpk { get; set; }

    public string Ofcname { get; set; } = null!;

    public string Ofcshtname { get; set; } = null!;

    public int? RomIdpk { get; set; }

    public string Romname { get; set; } = null!;

    public string RomShtName { get; set; } = null!;

    public string TdrRmks { get; set; } = null!;

    public bool EmpActive { get; set; }

    public string EmpFax { get; set; } = null!;

    public bool TdrActive { get; set; }

    public bool TdoActive { get; set; }

    public string EmpResidenceNo { get; set; } = null!;

    public int? JbtIdpk { get; set; }

    public string? JbtName { get; set; }

    public string? JbtShtName { get; set; }

    public bool? EmpIsDirector { get; set; }

    public bool? EmpIsManager { get; set; }

    public bool? EmpIsSupervisor { get; set; }

    public bool? EmpIsStaff { get; set; }

    public bool? EmpIsSeniorStaff { get; set; }

    public bool? EmpIsJuniorStaff { get; set; }

    public bool? EmpIsManagementStaff { get; set; }

    public bool? EmpIsServicePerson { get; set; }

    public bool? EmpIsVoluntaryPerson { get; set; }

    public string? EmpName1 { get; set; }

    public string? EmpName2 { get; set; }

    public string? EmpName3 { get; set; }

    public string? EmpName4 { get; set; }

    public bool? EmpHideMobNo { get; set; }

    public string? EmpMobNox { get; set; }

    public bool? EmpShowInTelDirectory { get; set; }

    public string? EmpSupStaffNo { get; set; }

    public string? EmpSupLastname { get; set; }

    public string? EmpSupName { get; set; }

    public int? AscIdpk { get; set; }

    public string? AscName { get; set; }

    public string? AscShtName { get; set; }

    public int? PstIdpk { get; set; }

    public string? PstName { get; set; }

    public string? PstShtName { get; set; }

    public int? TdrCreatedBy { get; set; }

    public int? TdrEditedBy { get; set; }

    public DateTime? TdrCreationDate { get; set; }

    public DateTime? TdrEditedDate { get; set; }

    public string? EmpIntercom { get; set; }

    public string? EmpOfficialEmail { get; set; }

    public string? EmpPersonalEmail { get; set; }

    public byte[]? PpxPicture { get; set; }

    public string? EmpTelNo { get; set; }
}
