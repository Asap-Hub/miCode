using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenVoteSetting
{
    public int VtsIdpk { get; set; }

    public string? VtsTopic { get; set; }

    public DateTime? VtsStartDate { get; set; }

    public DateTime? VtsEndDate { get; set; }

    public bool? VtsActive { get; set; }

    public string? VtsRmks { get; set; }

    public int? VtsCreatedBy { get; set; }

    public int? VtsEditedBy { get; set; }

    public DateTime? VtsCreationDate { get; set; }

    public DateTime? VtsEditedDate { get; set; }
}
