using Microsoft.EntityFrameworkCore;
using zoo_backend_vs.Data;

var builder = WebApplication.CreateBuilder(args);

// 注册 HttpClient
builder.Services.AddHttpClient();

// 跨域存取設定
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
        policy =>
        {
            policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
        });
});

// 其他服务注册
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); ;

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
//app.UseSwaggerUI(options => // UseSwaggerUI is called only in Development.
//{
//    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
//    options.RoutePrefix = string.Empty;
//});

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=serviceSpot}/{action=Index}/{id?}");


app.Run();
