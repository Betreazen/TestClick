var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Разрешаем использование статических файлов из папки wwwroot
app.UseStaticFiles();

// Настраиваем приложение так, чтобы оно открывало index.html по умолчанию
app.MapFallbackToFile("index.html");

app.Run();
