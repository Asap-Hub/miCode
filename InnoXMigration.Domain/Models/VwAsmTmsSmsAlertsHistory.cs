using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTmsSmsAlertsHistory
{
    public int? SahMaintenanceScheduleIdfk { get; set; }

    public int? SahRecipientEmpIdfk { get; set; }

    public string? SahMessage { get; set; }

    public bool? SahActive { get; set; }

    public string? SahMobNo { get; set; }

    public string? SahRmks { get; set; }

    public string? SahCreatedBy { get; set; }

    public int? SahEditedBy { get; set; }

    public int MtsIdpk { get; set; }

    public int? MtsVehicleDetailIdfk { get; set; }

    public DateTime? MtsDate { get; set; }

    public int? MtsDriverEmpIdfk { get; set; }

    public int? MtsOwnerEmpIdfk { get; set; }

    public bool? MtsPromptOwner { get; set; }

    public bool? MtsPromptDriver { get; set; }

    public int VdtIdpk { get; set; }

    public string VdtRegNo { get; set; } = null!;

    public string? MdlName { get; set; }

    public string? MdlShtName { get; set; }

    public int? VmkIdpk { get; set; }

    public string? VmkName { get; set; }

    public string? VmkShtName { get; set; }

    public int? VhcIdpk { get; set; }

    public string? VhcName { get; set; }

    public string? VhcShtName { get; set; }

    public string? MftName { get; set; }

    public string? MftShtName { get; set; }

    public int MtpIdpk { get; set; }

    public string? MtpName { get; set; }

    public string? MtpShtName { get; set; }

    public int DriverEmpId { get; set; }

    public string? DriverStaffNo { get; set; }

    public string? DriverLname { get; set; }

    public string? DriverFname { get; set; }

    public string DriverOnames { get; set; } = null!;

    public string? DriverName { get; set; }

    public string? DriverName1 { get; set; }

    public int OwnerEmpId { get; set; }

    public string? OwnerStaffNo { get; set; }

    public string? OwnerLname { get; set; }

    public string? OwnerFname { get; set; }

    public string OwnerOnames { get; set; } = null!;

    public string OwnerHrmsName { get; set; } = null!;

    public string? OwnerName { get; set; }

    public string? OwnerName1 { get; set; }

    public string? OwnerName4 { get; set; }

    public bool? MtsSmsSent { get; set; }

    public DateTime? SahCreationDate { get; set; }

    public int DriverDptIdpk { get; set; }

    public string DriverDptName { get; set; } = null!;

    public string DriverDptShtName { get; set; } = null!;

    public int DriverSxnIdpk { get; set; }

    public string DriverSxnName { get; set; } = null!;

    public string DriverSxnShtName { get; set; } = null!;

    public int OwnerDptIdpk { get; set; }

    public string OwnerDptName { get; set; } = null!;

    public string OwnerDptShtName { get; set; } = null!;

    public int OwnerSxnIdpk { get; set; }

    public string OwnerSxnName { get; set; } = null!;

    public string OwnerSxnShtName { get; set; } = null!;

    public byte MtsSmsCount { get; set; }
}
