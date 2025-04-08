using InfoPill.Communication.Requests;
using InfoPill.Communication.Responses;

namespace InfoPill.Application.UseCases.Pill.Register;

public class RegisterPillUseCase
{
    public ResponseRegisterPillJson Execute(RequestPillJson request)
    {
        return new ResponseRegisterPillJson
        {
            PillId = 1,
            PillName = request.PillName,
            Category = request.Category
        };

    }
}
