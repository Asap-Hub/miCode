using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenModulesx
{
    public int FmdlIdpk { get; set; }

    public string? FmdlName { get; set; }

    public string? FmdlShtName { get; set; }

    public int? FmdlProjectIdfk { get; set; }

    public bool? FmdlActive { get; set; }

    public string? FmdlCode { get; set; }

    public byte? FmdlOrder { get; set; }

    public bool? FmdlIsHelpModule { get; set; }

    public byte? FmdlHelpModuleOrder { get; set; }

    public bool? FmdlIsHelpModuleOnly { get; set; }

    public string? FmdlRmks { get; set; }

    public int? FmdlCreatedBy { get; set; }

    public int? FmdlEditedBy { get; set; }

    public DateTime? FmdlCreationDate { get; set; }

    public DateTime? FmdlEditedDate { get; set; }
}
