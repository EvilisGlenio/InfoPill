using InfoPill.Communication.Enuns;

namespace InfoPill.Communication.Requests;

public class RequestPillJson
{
    public string PillName { get; set; } = string.Empty;
    public PillCategory Category { get; set; }
}
