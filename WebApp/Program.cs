using System.Net.Mime;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", (HttpContext context) => {
    string html = @"
    <html>
        <h1>Hello World</h1>
    </html>
    ";
    WriteHtml(context, html);
});

app.Run();

void WriteHtml(HttpContext context, string html)
{
    context.Response.ContentType = MediaTypeNames.Text.Html;
    context.Response.ContentLength = Encoding.UTF8.GetByteCount(html);
    context.Response.WriteAsync(html);
}