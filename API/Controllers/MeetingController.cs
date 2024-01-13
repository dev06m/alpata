

using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class MeetingController : ControllerBase
{
    private readonly Context _context;

    public MeetingController(Context context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Meeting>> GetMeetings()
    {
        return null;
    }

    
}
