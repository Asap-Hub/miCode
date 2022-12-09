using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenApplicationModule
{
    public int AmdIdpk { get; set; }

    public string? AmdName { get; set; }

    public string? AmdShtName { get; set; }

    public int? AmdProjectIdfk { get; set; }

    public bool? AmdActive { get; set; }

    public string? AmdCode { get; set; }

    public byte? AmdOrder { get; set; }

    public bool? AmdIsHelpModule { get; set; }

    public byte? AmdHelpModuleOrder { get; set; }

    public bool? AmdIsHelpModuleOnly { get; set; }

    public string? AmdRmks { get; set; }

    public int? AmdCreatedBy { get; set; }

    public int? AmdEditedBy { get; set; }

    public DateTime? AmdCreationDate { get; set; }

    public DateTime? AmdEditedDate { get; set; }
}
