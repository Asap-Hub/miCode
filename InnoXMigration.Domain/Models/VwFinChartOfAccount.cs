using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class VwFinChartOfAccount
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

    public int? AtpIdpk { get; set; }

    public string? AtpName { get; set; }

    public string? AtpShtName { get; set; }

    public string? AtpCode { get; set; }

    public string? AtpDescription { get; set; }

    public int? AgpIdpk { get; set; }

    public string? AgpName { get; set; }

    public string? AgpShtName { get; set; }

    public string? AgpCode { get; set; }

    public string? AgpDescription { get; set; }
}
