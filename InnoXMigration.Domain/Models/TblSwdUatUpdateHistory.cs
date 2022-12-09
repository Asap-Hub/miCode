using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSwdUatUpdateHistory
{
    public int UuhIdpk { get; set; }

    public int? UuhEmpIdfk { get; set; }

    public int? UuhProcessIdfk { get; set; }

    public string? UuhComment { get; set; }

    public string? UuhActionBy { get; set; }

    public string? UuhStatus { get; set; }

    public string? UuhImpact { get; set; }

    public string? UuhRmks { get; set; }

    public int? UuhCreatedBy { get; set; }

    public DateTime? UuhCreationDate { get; set; }
}
