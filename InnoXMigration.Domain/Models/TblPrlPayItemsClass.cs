using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblPrlPayItemsClass
{
    public int PicIdpk { get; set; }

    public string? PicName { get; set; }

    public string? PicShtName { get; set; }

    public bool? PicActive { get; set; }

    public string? PicRmks { get; set; }

    public int? PicCreatedBy { get; set; }

    public int? PicEditedBy { get; set; }

    public DateTime? PicCreationDate { get; set; }

    public DateTime? PicEditedDate { get; set; }
}
