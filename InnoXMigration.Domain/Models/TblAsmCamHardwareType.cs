using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAsmCamHardwareType
{
    public int HwtIdpk { get; set; }

    public string? HwtName { get; set; }

    public string? HwtShtName { get; set; }

    public bool? HwtOsInstallable { get; set; }

    public bool? HwtActive { get; set; }

    public string? HwtRmks { get; set; }

    public string? HwtCreatedBy { get; set; }

    public int? HwtEditedBy { get; set; }

    public DateTime? HwtCreationDate { get; set; }

    public DateTime? HwtEditedDate { get; set; }
}
