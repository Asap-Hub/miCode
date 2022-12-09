using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwAsmTmsVehicleModel
{
    public int MdlIdpk { get; set; }

    public string? MdlName { get; set; }

    public string? MdlShtName { get; set; }

    public int? MdlManufacturerIdfk { get; set; }

    public int? MdlVehicleMakeIdfk { get; set; }

    public bool? MdlActive { get; set; }

    public string? MdlRmks { get; set; }

    public string? MdlCreatedBy { get; set; }

    public int? MdlEditedBy { get; set; }

    public DateTime? MdlCreationDate { get; set; }

    public DateTime? MdlEditedDate { get; set; }

    public int VmkIdpk { get; set; }

    public string? VmkName { get; set; }

    public string? VmkShtName { get; set; }

    public bool? VmkActive { get; set; }

    public string? VmkRmks { get; set; }

    public string? VmkCreatedBy { get; set; }

    public int? VmkEditedBy { get; set; }

    public DateTime? VmkCreationDate { get; set; }

    public DateTime? VmkEditedDate { get; set; }

    public int MftIdpk { get; set; }

    public string? MftName { get; set; }

    public string? MftShtName { get; set; }

    public bool? MftActive { get; set; }

    public string? MftRmks { get; set; }

    public string? MftCreatedBy { get; set; }

    public int? MftEditedBy { get; set; }

    public DateTime? MftCreationDate { get; set; }

    public DateTime? MftEditedDate { get; set; }

    public int? VmkVehicleClassIdfk { get; set; }

    public int VhcIdpk { get; set; }

    public string? VhcName { get; set; }

    public string? VhcShtName { get; set; }

    public bool? VhcActive { get; set; }

    public string? VhcRmks { get; set; }

    public string? VhcCreatedBy { get; set; }

    public int? VhcEditedBy { get; set; }

    public DateTime? VhcCreationDate { get; set; }

    public DateTime? VhcEditedDate { get; set; }
}
