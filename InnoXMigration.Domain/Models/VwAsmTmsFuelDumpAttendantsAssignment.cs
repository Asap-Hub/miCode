using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTmsFuelDumpAttendantsAssignment
{
    public int FaaIdpk { get; set; }

    public bool? FaaActive { get; set; }

    public int EmpIdpk { get; set; }

    public string? EmpStaffNo { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpFirstName { get; set; }

    public string EmpOthernames { get; set; } = null!;

    public string EmpLegacyName { get; set; } = null!;

    public string? EmpName { get; set; }

    public string? EmpName1 { get; set; }

    public string? EmpName2 { get; set; }

    public string? EmpName3 { get; set; }

    public string? EmpName4 { get; set; }

    public string? EmpFlnamesNoSpace { get; set; }

    public string? EmpLfonamesNoSpace { get; set; }

    public string? EmpLfnamesNoSpace { get; set; }

    public string? FaaRmks { get; set; }

    public int? FaaEmpIdfk { get; set; }

    public int? FaaCreatedBy { get; set; }

    public int? FaaEditedBy { get; set; }

    public DateTime? FaaCreationDate { get; set; }

    public DateTime? FaaEditedDate { get; set; }

    public int LocIdpk { get; set; }

    public string LocName { get; set; } = null!;

    public string LocShtName { get; set; } = null!;

    public bool? FaaManage { get; set; }

    public bool? FaaView { get; set; }

    public int SstIdpk { get; set; }

    public string? SstName { get; set; }

    public string? SstShtName { get; set; }

    public string? SstStationNo { get; set; }

    public int? SstServiceProviderIdfk { get; set; }

    public int? SstTownIdfk { get; set; }

    public bool? SstActive { get; set; }

    public string? SstRmks { get; set; }

    public string? SstCreatedBy { get; set; }

    public int? SstEditedBy { get; set; }

    public int TwnIdpk { get; set; }

    public string? TwnName { get; set; }

    public string? TwnShtName { get; set; }

    public int DstIdpk { get; set; }

    public string DstName { get; set; } = null!;

    public string DstShtName { get; set; } = null!;

    public int? RgnIdpk { get; set; }

    public string? RgnName { get; set; }

    public string? RgnShtName { get; set; }

    public int SpdIdpk { get; set; }

    public string? SpdName { get; set; }

    public string? SpdShtName { get; set; }

    public string? SpdMainContact { get; set; }

    public string? SpdMobNos { get; set; }

    public string? SpdEmail { get; set; }

    public string? SpdTelNos { get; set; }

    public string? SpdPostalAddress { get; set; }

    public string? SpdResidentialAddress { get; set; }

    public bool? SpdActive { get; set; }

    public string? SstMainContacts { get; set; }

    public string? SstTelNos { get; set; }

    public string? SsteMails { get; set; }

    public bool? SpdFuelDump { get; set; }

    public int? FaaServiceStationIdfk { get; set; }

    public bool FaaAuthorise { get; set; }

    public string EmpMobNox { get; set; } = null!;

    public string EmpMobNo { get; set; } = null!;

    public string EmpIntercom { get; set; } = null!;

    public int DptIdpk { get; set; }

    public string DptName { get; set; } = null!;

    public string DptShtName { get; set; } = null!;

    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;
}
