using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblVrgCompBankDetail
{
    public int FcbdIdpk { get; set; }

    public int? FcbdCompIdfk { get; set; }

    public int? FcbdBankIdfk { get; set; }

    public int? FcbdBranchIdfk { get; set; }

    public DateTime? FcbdStartDate { get; set; }

    public DateTime? FcbdEndDate { get; set; }

    public string? FcbdAccountNo { get; set; }

    public string? FcbdPhoneNo { get; set; }

    public string? FcbdRmks { get; set; }

    public bool? FcbdActive { get; set; }

    public int? FcbdCreatedBy { get; set; }

    public int? FcbdEditedBy { get; set; }

    public DateTime? FcbdCreationDate { get; set; }

    public DateTime? FcbdEditedDate { get; set; }
}
