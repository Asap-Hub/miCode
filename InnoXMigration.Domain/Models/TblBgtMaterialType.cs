using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBgtMaterialType
{
    public int MttIdpk { get; set; }

    public string? MttName { get; set; }

    public string? MttShtName { get; set; }

    public bool? MttActive { get; set; }

    public string? MttRmks { get; set; }

    public int? MttCreatedBy { get; set; }

    public int? MttEditedBy { get; set; }

    public DateTime? MttCreationDate { get; set; }

    public DateTime? MttEditedDate { get; set; }
}
