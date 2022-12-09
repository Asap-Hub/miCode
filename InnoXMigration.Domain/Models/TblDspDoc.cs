using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblDspDoc
{
    public int FdocIdpk { get; set; }

    public string? FdocName { get; set; }

    public string? FdocTitle { get; set; }

    public string? FdocExtension { get; set; }

    public bool? FdocIsBackMusic { get; set; }

    public short? FdocDisplTime { get; set; }

    public DateTime? FdocStartDate { get; set; }

    public DateTime? FdocEndDate { get; set; }

    public bool? FdocPauseBackMusic { get; set; }

    public decimal? FdocOrder { get; set; }

    public bool? FdocActive { get; set; }

    public bool? FdocPicked { get; set; }

    public string? FdocRemarks { get; set; }

    public int? FdocCreatedBy { get; set; }

    public DateTime? FdocCreationDate { get; set; }
}
