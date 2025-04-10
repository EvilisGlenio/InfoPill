using InfoPill.Communication.Enuns;

namespace InfoPill.Communication.Responses;

public class ResponsePillJson
{
    public int PillId { get; set; }
    public string PillName { get; set; } = string.Empty;
    public PillCategory Category { get; set; }
}
