using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblSwdApplicationModule
{
    public int ApmIdpk { get; set; }

    public string? ApmName { get; set; }

    public string? ApmShtName { get; set; }

    public int? ApmProjectIdfk { get; set; }

    public bool? ApmActive { get; set; }

    public string? ApmCode { get; set; }

    public byte? ApmOrder { get; set; }

    public bool? ApmIsHelpModule { get; set; }

    public byte? ApmHelpModuleOrder { get; set; }

    public bool? ApmIsHelpModuleOnly { get; set; }

    public string? ApmRmks { get; set; }

    public int? ApmCreatedBy { get; set; }

    public int? ApmEditedBy { get; set; }

    public DateTime? ApmCreationDate { get; set; }

    public DateTime? ApmEditedDate { get; set; }
}
