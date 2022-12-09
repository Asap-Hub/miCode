using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblFinChartOfAccount
{
    public int CoaIdpk { get; set; }

    public string? CoaAccountNo { get; set; }

    public string? CoaName { get; set; }

    public string? CoaShtName { get; set; }

    public string? CoaDescription { get; set; }

    public int? CoaAccountTypeIdfk { get; set; }

    public int? CoaAccountGroupIdfk { get; set; }

    public bool? CoaActive { get; set; }

    public string? CoaRmks { get; set; }

    public string? CoaCreatedBy { get; set; }

    public int? CoaEditedBy { get; set; }

    public DateTime? CoaCreationDate { get; set; }

    public DateTime? CoaEditedDate { get; set; }
}
