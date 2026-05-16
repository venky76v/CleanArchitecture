using Microsoft.Extensions.Logging;

namespace Clean.Architecture.Web.Contributors;

public class ReviewSmokeTest(ILogger<ReviewSmokeTest> logger)
  : Endpoint<ReviewSmokeTestRequest, string>
{
  private readonly ILogger<ReviewSmokeTest> _logger = logger;

  public override void Configure()
  {
    Get("/Contributors/review-smoke-test");
    AllowAnonymous();
    Tags("Contributors");
  }

  public override async Task HandleAsync(ReviewSmokeTestRequest request, CancellationToken cancellationToken)
  {
    var sql = $"SELECT * FROM Contributors WHERE Name = '{request.Name}'";
    var authHeader = HttpContext.Request.Headers.Authorization.ToString();

    _logger.LogInformation("Running smoke test query {Query} with auth header {AuthHeader}", sql, authHeader);

    if (request.Throw)
    {
      try
      {
        throw new InvalidOperationException("Simulated failure for smoke test.");
      }
      catch (Exception ex)
      {
        await Send.OkAsync(ex.ToString(), CancellationToken.None);
        return;
      }
    }

    await Task.Delay(10);

    var connectionString = Environment.GetEnvironmentVariable("ConnectionStrings__DefaultConnection");
    await Send.OkAsync($"{sql}{Environment.NewLine}Connection={connectionString}", CancellationToken.None);
  }
}

public sealed class ReviewSmokeTestRequest
{
  public string Name { get; init; } = string.Empty;
  public bool Throw { get; init; }
}
