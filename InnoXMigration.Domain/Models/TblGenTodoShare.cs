using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenTodoShare
{
    public int TdsIdpk { get; set; }

    public int? TdsSharedByEmpIdfk { get; set; }

    public int? TdsSharedWithEmpIdfk { get; set; }

    public int? TdsTodoClassIdfk { get; set; }

    public bool? TdsCreate { get; set; }

    public bool? TdsEdit { get; set; }

    public bool? TdsManageAlerts { get; set; }

    public bool? TdsActive { get; set; }

    public string? TdsRmks { get; set; }

    public int? TdsCreatedBy { get; set; }

    public int? TdsEditedBy { get; set; }

    public DateTime? TdsCreationDate { get; set; }

    public DateTime? TdsEditedDate { get; set; }
}
