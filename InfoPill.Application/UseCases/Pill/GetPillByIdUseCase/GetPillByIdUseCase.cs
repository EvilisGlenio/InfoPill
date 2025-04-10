using InfoPill.Communication.Responses;

namespace InfoPill.Application.UseCases.Pill.GetPillByIdUseCase;

public class GetPillByIdUseCase
{
    public ResponsePillJson Execute(int id)
    {
        return new ResponsePillJson
        {
            PillId = id,
            PillName = "Paracetamol",
            Category = Communication.Enuns.PillCategory.Analgesic
        };
    }
}
