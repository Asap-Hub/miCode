using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSsvTrekkingLocation
{
    public int TlcIdpk { get; set; }

    public string? TlcName { get; set; }

    public string? TlcShtName { get; set; }

    public string? TlcPlc { get; set; }

    public string? TlcContacts { get; set; }

    public string? TlcDept { get; set; }

    public string? TlcArea { get; set; }

    public bool? TlcActive { get; set; }

    public string? TlcRmks { get; set; }

    public string? TlcCreatedBy { get; set; }

    public int? TlcEditedBy { get; set; }

    public DateTime? TlcCreationDate { get; set; }

    public DateTime? TlcEditedDate { get; set; }
}
