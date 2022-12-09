using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblHrJobDescShare
{
    public int JdsIdpk { get; set; }

    public DateTime? JdsDate { get; set; }

    public int? JdsJobDescIdfk { get; set; }

    public int? JdsEmpIdfk { get; set; }

    public int? JbsDocIdfk { get; set; }

    public bool? JdsOwner { get; set; }

    public bool? JdsReader { get; set; }

    public bool? JdsPrint { get; set; }

    public bool? JdsSign { get; set; }

    public string? JdsType { get; set; }

    public int? JdsActive { get; set; }

    public int? JdsCreatedBy { get; set; }

    public DateTime? JdsCreationDate { get; set; }
}
