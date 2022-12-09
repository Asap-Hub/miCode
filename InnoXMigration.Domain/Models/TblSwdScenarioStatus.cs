using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSwdScenarioStatus
{
    public int SstIdpk { get; set; }

    public string? SstName { get; set; }

    public string? SstShtName { get; set; }

    public decimal? SstOrder { get; set; }

    public bool? SstActive { get; set; }

    public string? SstRmks { get; set; }

    public int? SstCreatedBy { get; set; }

    public int? SstEditedBy { get; set; }

    public DateTime? SstCreationDate { get; set; }

    public DateTime? SstEditedDate { get; set; }
}
