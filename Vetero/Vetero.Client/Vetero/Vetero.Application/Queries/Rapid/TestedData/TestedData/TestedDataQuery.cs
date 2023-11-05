using MediatR;
using Vetero.Shared.ViewModels.Rapid.TestedData;

namespace Vetero.Application.Queries.Rapid.TestedData.TestedData
{
    public class TestedDataQuery : IRequest<TestedDataModel>
    {
        public string DateToCompare { get; set; }
    }
}
