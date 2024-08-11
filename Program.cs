var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// ��������� ������������� ����������� ������ �� ����� wwwroot
app.UseStaticFiles();

// ����������� ���������� ���, ����� ��� ��������� index.html �� ���������
app.MapFallbackToFile("index.html");

app.Run();
