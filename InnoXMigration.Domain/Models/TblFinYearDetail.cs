using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblFinYearDetail
{
    public int YdtIdpk { get; set; }

    public string? YdtName { get; set; }

    public string? YdtShtName { get; set; }

    public DateTime? YdtStartDate { get; set; }

    public DateTime? YdtEndDate { get; set; }

    public bool? YdtOpened { get; set; }

    public bool? YdtActive { get; set; }

    public string? YdtRmks { get; set; }

    public string? YdtCreatedBy { get; set; }

    public int? YdtEditedBy { get; set; }

    public DateTime? YdtCreationDate { get; set; }

    public DateTime? YdtEditedDate { get; set; }
}
