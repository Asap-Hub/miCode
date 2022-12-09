using System;
using System.Collections.Generic;

namespace InnoXMigration.Domain.Models;

public partial class TblBgtCompsAndAccessory
{
    public int CaaIdpk { get; set; }

    public string? CaaBudgetIdfk { get; set; }

    public string? CaaSectionIdfk { get; set; }

    public string? CaaDesktop { get; set; }

    public string? CaaNotebook { get; set; }

    public string? CaaNetworkPrinter { get; set; }

    public string? CaaOrdinaryPrinter { get; set; }

    public string? CaaA3printer { get; set; }

    public string? CaaColouredPrinterAllInOne { get; set; }

    public string? CaaScanner { get; set; }

    public string? CaaLcdProjector { get; set; }

    public string? CaaDigitalCamera { get; set; }

    public string? CaaPlotter { get; set; }

    public string? CaaVideoCamera { get; set; }

    public string? CaaTotalEstimatedUsd { get; set; }

    public string? CaaGrandTotalGhc { get; set; }

    public bool? CaaApproved { get; set; }

    public int? CaaApprovalDate { get; set; }

    public int? CaaApprovedBy { get; set; }

    public string? CaaApprovalRmks { get; set; }

    public string? CaaRmks { get; set; }

    public int? CaaCreatedBy { get; set; }

    public int? CaaEditedBy { get; set; }

    public DateTime? CaaCreationDate { get; set; }

    public DateTime? CaaEditedDate { get; set; }
}
