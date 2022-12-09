using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblGenLoginDetail
{
    public int LdtIdpk { get; set; }

    public string? LdtUserIdfk { get; set; }

    public DateTime? LdtLoginDate { get; set; }

    public DateTime? LdtLogoutDate { get; set; }

    public int? LdtLoggedOutBy { get; set; }

    public string? LdtAppVersion { get; set; }

    public DateTime? LdtLastAppBuildDate { get; set; }

    public string? LdtOsName { get; set; }

    public string? LdtOsPlatform { get; set; }

    public string? LdtOsVersion { get; set; }

    public long? LdtTotalPhysicalMemory { get; set; }

    public long? LdtTotalVirtualMemory { get; set; }

    public long? LdtAvailablePhysicalMemory { get; set; }

    public long? LdtAvailableVirtualMemory { get; set; }

    public string? LdtIp { get; set; }

    public string? LdtHostname { get; set; }

    public bool? LdtLoggedIn { get; set; }
}
