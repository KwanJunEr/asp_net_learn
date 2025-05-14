var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (HttpContext context) =>
{
    //Context.Request.
    await context.Response.WriteAsync($"The method is:{context.Request.Method}\n\n");
    await context.Response.WriteAsync($"The URL is:{context.Request.Path}\n\n");

    await context.Response.WriteAsync($"\r\nHeaders: \r\n");
    foreach(var key in context.Request.Headers.Keys)
    {
        await context.Response.WriteAsync($"{key} : {context.Request.Headers[key]}\r\n");
    }

});

app.Run();
