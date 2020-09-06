using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
//файлы для скачивания
using System.IO;
using Microsoft.Extensions.FileProviders;
//логгирование
using Microsoft.Extensions.Logging;

namespace WebApplication1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //для логгирования - 3ий пар-р
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILogger<Startup> logger)
        {
            //стартовые страницы
            //1ый способ
            app.UseDefaultFiles();                      //default.html, default.htm, index.html, html.htm

            //2ой способ
            /*
            DefaultFilesOptions options = new DefaultFilesOptions();
            options.DefaultFileNames.Clear();       //удаляем имена файлов по умолч
            options.DefaultFileNames.Add("staticpage.html");    //добавляем новое имя файла
            app.UseDefaultFiles(options);               //установка параметров
            */

            //добавить заголовок
            app.UseStaticFiles(new StaticFileOptions
            {
                OnPrepareResponse = ctx =>
                {
                    ctx.Context.Response.Headers.Append("X-KNV20", "2020-07-04");
                }
            });

            //работа со стат.файлами
            app.UseStaticFiles();

            app.UseStaticFiles(
                new StaticFileOptions
                {
                    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "Html")),
                    RequestPath = "/Html"
                });

            //файлы для скачивания
            //UseDirectoryBrowser повзол юзерам просматривать содержимое каталогов на сайте
            app.UseDirectoryBrowser(new DirectoryBrowserOptions
            {
                FileProvider = new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "docs")),
                RequestPath = "/docs"
            });

            //логгирование
                    //выводится только логирование favicon.ico
                    //можно создать отдельный проект для логгирования
            app.Run(async (context) =>
            {
                // пишем на консоль информацию
                //для к.уровня/метода опред.своя метка и цвет, кот.позвол выделить сообщения соотв.ур-ня
                logger.LogCritical("LogCritical {0}", context.Request.Path);
                logger.LogDebug("LogDebug {0}", context.Request.Path);
                logger.LogError("LogError {0}", context.Request.Path);
                logger.LogInformation("LogInformation {0}", context.Request.Path);
                logger.LogWarning("LogWarning {0}", context.Request.Path);
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
