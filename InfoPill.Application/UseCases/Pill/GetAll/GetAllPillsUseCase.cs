using InfoPill.Communication.Responses;

namespace InfoPill.Application.UseCases.Pill.GetAll;

public class GetAllPillsUseCase
{
    // This method is used to execute the use case of getting all pills.
    public ResponseAllPillJson Execute()
    {
        // This is a sample response with a list of pills.
        return new ResponseAllPillJson()
        {
            // This is a sample list of pills.
            Pills = new List<ResponseShortPillJson>()
            {
                // This is a sample pill with its properties.
                //In future, this will be replaced with a call to the database to get the pills.
                new ResponseShortPillJson()
                {
                    PillId = 1,
                    PillName = "Aspirin",
                    Category = Communication.Enuns.PillCategory.Anesthetic,
                }
            }
        };
    }
}