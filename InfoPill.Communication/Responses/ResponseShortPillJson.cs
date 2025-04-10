using InfoPill.Communication.Enuns;

namespace InfoPill.Communication.Responses;

public class ResponseShortPillJson
{
    // This class is used to represent a short response for a pill.
    public int PillId { get; set; }
    public string PillName { get; set; } = string.Empty;
    public PillCategory Category { get; set; }
}
