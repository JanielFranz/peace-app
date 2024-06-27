using System.ComponentModel.DataAnnotations.Schema;
using EntityFrameworkCore.CreatedUpdatedDate.Contracts;

namespace PeaceApp.API.Report.Domain.Model.Aggregates;

public partial class ReportManagement : IEntityWithCreatedUpdatedDate
{
    [Column("CreatedAt")]public DateTimeOffset? CreatedDate { get; set; }
    [Column("UpdatedAt")]public DateTimeOffset? UpdatedDate { get; set; }

    public DateTime ToDate(DateTimeOffset createdDate)
    {
        return createdDate.Date;
    }
}