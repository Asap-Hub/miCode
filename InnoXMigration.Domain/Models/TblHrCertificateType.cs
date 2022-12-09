using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrCertificateType
{
    public int CttIdpk { get; set; }

    public string? CttName { get; set; }

    public string? CttShtName { get; set; }

    public string? CttShtCode { get; set; }

    public bool? CttActive { get; set; }

    public string? CttRmks { get; set; }

    public int? CttCreatedBy { get; set; }

    public int? CttEditedBy { get; set; }

    public DateTime? CttCreationDate { get; set; }

    public DateTime? CttEditedDate { get; set; }
}
