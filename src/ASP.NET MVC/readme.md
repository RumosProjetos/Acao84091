# ASP.NET MVC

## Aula 01 - ASP.NET MVC


- Procurar Livro: (20486D-DevelopingASPNETMVCWebApplications Trainer handbook.pdf)

- [ASP.NET MVC Microsoft](https://github.com/MicrosoftLearning/20486D-DevelopingASPNETMVCWebApplications)

- [Exercício 01](https://github.com/MicrosoftLearning/20486D-DevelopingASPNETMVCWebApplications/blob/master/Instructions/20486D_MOD01_LAK.md)

- [Exercício 02](https://github.com/MicrosoftLearning/20486D-DevelopingASPNETMVCWebApplications/blob/master/Instructions/20486D_MOD02_LAK.md)


- [Dependency injection in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-8.0)

```csharp	
using DependencyInjectionSample.Interfaces;
using DependencyInjectionSample.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddScoped<IMyDependency, MyDependency2>();

builder.Services.AddSingleton<IMyDependencySing, MyDependencySing2>();

var app = builder.Build();
```