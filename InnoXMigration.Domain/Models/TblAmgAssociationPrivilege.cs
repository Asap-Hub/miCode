using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblAmgAssociationPrivilege
{
    public int ApvIdpk { get; set; }

    public int? ApvEmpIdfk { get; set; }

    public int? ApvAssociationIdfk { get; set; }

    public bool? ApvAdmin { get; set; }

    public bool? ApvView { get; set; }

    public bool? ApvSendSms { get; set; }

    public bool? ApvSecretary { get; set; }

    public bool? ApvChairman { get; set; }

    public bool? ApvAlertFyi { get; set; }

    public bool? ApvActive { get; set; }

    public string? ApvRmks { get; set; }

    public int? ApvCreatedBy { get; set; }

    public int? ApvEditedBy { get; set; }

    public DateTime? ApvCreationDate { get; set; }

    public DateTime? ApvEditedDate { get; set; }
}
