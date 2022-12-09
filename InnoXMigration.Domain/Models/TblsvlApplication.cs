using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblsvlApplication
{
    public int AppIdpk { get; set; }

    public string? AppName { get; set; }

    public string? AppShtName { get; set; }

    public bool? AppActive { get; set; }

    public string? AppRmks { get; set; }

    public int? AppCreatedBy { get; set; }

    public int? AppEditedBy { get; set; }

    public DateTime? AppCreationDate { get; set; }

    public DateTime? AppEditedDate { get; set; }
}
