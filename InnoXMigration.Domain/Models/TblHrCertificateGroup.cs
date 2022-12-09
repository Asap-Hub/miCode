using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrCertificateGroup
{
    public int CgpIdpk { get; set; }

    public string? CgpName { get; set; }

    public string? CgpShtName { get; set; }

    public string? CgpShtCode { get; set; }

    public bool? CgpActive { get; set; }

    public string? CgpRmks { get; set; }

    public int? CgpCreatedBy { get; set; }

    public int? CgpEditedBy { get; set; }

    public DateTime? CgpCreationDate { get; set; }

    public DateTime? CgpEditedDate { get; set; }
}
