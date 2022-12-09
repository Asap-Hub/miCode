using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblsvlServerAccountDetail
{
    public int SadIdpk { get; set; }

    public DateTime? SadDate { get; set; }

    public int? SadServerIdfk { get; set; }

    public string? SadAccountNameIdfk { get; set; }

    public string? SadPassword { get; set; }

    public string? SadPrivilege { get; set; }

    public bool? SadActive { get; set; }

    public string? SadRmks { get; set; }

    public int? SadCreatedBy { get; set; }

    public int? SadEditedBy { get; set; }

    public DateTime? SadCreationDate { get; set; }

    public DateTime? SadEditedDate { get; set; }
}
