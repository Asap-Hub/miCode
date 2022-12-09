using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenDefaultSmsCat
{
    public int FdscIdpk { get; set; }

    public string? FdscName { get; set; }

    public string? FdscShtName { get; set; }

    public string? FdscSender { get; set; }

    public string? FdscOwner { get; set; }

    public int? FdscSenderIdfk { get; set; }

    public int? FdscOwnerIdfk { get; set; }

    public bool? FdscActive { get; set; }

    public string? FdscRmks { get; set; }

    public int? FdscCreatedBy { get; set; }

    public int? FdscEditedBy { get; set; }

    public DateTime? FdscCreationDate { get; set; }

    public DateTime? FdscEditedDate { get; set; }
}
