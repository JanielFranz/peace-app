using PeaceApp.API.Report.Domain.Model.Aggregates;
using PeaceApp.API.Report.Interfaces.REST.Resources;

namespace PeaceApp.API.Report.Interfaces.REST.Transform;

public static class ReportResourceFromEntityAssembler
{
    public static ReportResource ToResourceFromEntity(ReportManagement entity)
    {
        return new ReportResource(entity.Id, entity.Type, entity.Date, entity.Time, entity.District, entity.Location,
            entity.Description, entity.UrlEvidence, entity.CitizenId);
    }
}