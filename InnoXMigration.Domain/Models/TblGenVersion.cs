using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenVersion
{
    public int VsnIdpk { get; set; }

    public DateTime? VsnDate { get; set; }

    public string? VsnVersion { get; set; }

    public byte[]? VsnWhatIsNew { get; set; }

    public string? VsnRmks { get; set; }

    public short? VsnMajor { get; set; }

    public short? VsnMinor { get; set; }

    public short? VsnBuild { get; set; }

    public short? VsnRevision { get; set; }

    public bool? VsnAlertUsers { get; set; }

    public bool? VsnActive { get; set; }

    public string? VsnDottedVersion { get; set; }

    public DateTime? VsnCreationDate { get; set; }

    public int? VsnCreatedBy { get; set; }

    public int? VsnEditedBy { get; set; }

    public DateTime? VsnEditedDate { get; set; }
}
