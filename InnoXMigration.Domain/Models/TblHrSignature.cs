using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrSignature
{
    public int SgnIdpk { get; set; }

    public int? SgnEmpIdfk { get; set; }

    public byte[]? SgnPicture { get; set; }

    public DateTime? SgnDate { get; set; }

    public bool? SgnActive { get; set; }

    public string? SgnRmks { get; set; }

    public int? SgnCreatedBy { get; set; }

    public int? SgnEditedBy { get; set; }

    public DateTime? SgnCreationDate { get; set; }

    public DateTime? SgnEditedDate { get; set; }
}
