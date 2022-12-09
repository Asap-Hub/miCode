using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenAduser
{
    public int AusIdpk { get; set; }

    public int? AusEmpIdfk { get; set; }

    public string? AusDisplayName { get; set; }

    public string? AusLname { get; set; }

    public string? AusFname { get; set; }

    public string? AusEmail { get; set; }

    public string? AusLogonAccount { get; set; }

    public string? AusInitials { get; set; }

    public string? AusActualAdname { get; set; }

    public bool? AusActive { get; set; }

    public string? AusRmks { get; set; }

    public int? AusCreatedby { get; set; }

    public int? AusLastEditedBy { get; set; }

    public DateTime? AusCreationDate { get; set; }

    public DateTime? AusLastEditedDate { get; set; }
}
