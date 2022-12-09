using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSwdProjectStage
{
    public int PsgIdpk { get; set; }

    public string? PsgName { get; set; }

    public string? PsgShtName { get; set; }

    public bool? PsgActive { get; set; }

    public string? PsgRmks { get; set; }

    public int? PsgCreatedBy { get; set; }

    public int? PsgEditedBy { get; set; }

    public DateTime? PsgCreationDate { get; set; }

    public DateTime? PsgEditedDate { get; set; }
}
