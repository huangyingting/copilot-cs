// In SortController.cs
using Microsoft.AspNetCore.Mvc;
using CopilotCsharp.Library;

[Route("api/[controller]")]
[ApiController]
public class SortController : ControllerBase
{
    public class SortInput
    {
        public int[] Array { get; set; }
    }

    [HttpPost]
    public ActionResult<int[]> QuickSort([FromBody] SortInput input)
    {
        Sort.QuickSort(input.Array);
        return input.Array;
    }
}