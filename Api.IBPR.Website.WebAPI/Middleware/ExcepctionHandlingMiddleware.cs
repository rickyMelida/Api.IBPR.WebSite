namespace Api.IBPR.Website.WebAPI.Middleware
{
	public class ExcepctionHandlingMiddleware
	{
		private readonly RequestDelegate _next;
		private readonly ILogger<ExcepctionHandlingMiddleware> _logger;

		public ExcepctionHandlingMiddleware(RequestDelegate next, ILogger<ExcepctionHandlingMiddleware> logger) =>
			(_next, _logger) = (next, logger);

		public async Task InvokeAsync(HttpContext context)
		{
			try
			{
				await _next(context);
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "An unhandled exception occurred.");
				context.Response.StatusCode = StatusCodes.Status500InternalServerError;
				await context.Response.WriteAsJsonAsync(new { error = "An unexpected error occurred." });
			}
		}
	}
}