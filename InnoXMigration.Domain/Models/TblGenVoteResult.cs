using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenVoteResult
{
    public int VtrIdpk { get; set; }

    public int? VtrEmpIdfk { get; set; }

    public byte? VtrQ1answer { get; set; }

    public byte? VtrQ2answer { get; set; }

    public byte? VtrVoteNo { get; set; }

    public string? VtrRmks { get; set; }

    public int? VtrCreatedBy { get; set; }

    public int? VtrEditedBy { get; set; }

    public DateTime? VtrCreationDate { get; set; }

    public DateTime? VtrEditedDate { get; set; }
}
