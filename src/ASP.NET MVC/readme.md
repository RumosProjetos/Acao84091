# ASP.NET MVC

## Aula 01 - ASP.NET MVC


- Procurar Livro: (20486D-DevelopingASPNETMVCWebApplications Trainer handbook.pdf)

- [ASP.NET MVC Microsoft](https://github.com/MicrosoftLearning/20486D-DevelopingASPNETMVCWebApplications)

- [Exercício 01](https://github.com/MicrosoftLearning/20486D-DevelopingASPNETMVCWebApplications/blob/master/Instructions/20486D_MOD01_LAK.md)

- [Exercício 02](https://github.com/MicrosoftLearning/20486D-DevelopingASPNETMVCWebApplications/blob/master/Instructions/20486D_MOD02_LAK.md)



## Aula 02 - Middleware

- [Middleware](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/middleware/?view=aspnetcore-8.0)


- [Dependency injection in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-8.0)


- [Exercício 01 - Middleware](https://github.com/MicrosoftLearning/20486D-DevelopingASPNETMVCWebApplications/blob/master/Instructions/20486D_MOD03_LAK.md)

### Módulo 3: Configurando Middleware e Serviços no ASP.NET Core

![alt text](image-1.png)

```csharp	
using DependencyInjectionSample.Interfaces;
using DependencyInjectionSample.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddScoped<IMyDependency, MyDependency2>();

builder.Services.AddSingleton<IMyDependencySing, MyDependencySing2>();

var app = builder.Build();
```

[Solid Principles](https://blog.stackademic.com/solid-principles-explained-with-real-time-examples-e39d1c167ba5)

![SOLID Principles](image.png)


# Princípios SOLID

Os princípios SOLID são um conjunto de cinco princípios de design que visam orientar a criação de software mantível, flexível e compreensível. Cada princípio concentra-se em um aspecto diferente do design de software e ajuda a garantir que sua base de código seja modular, extensível e fácil de manter.

## Princípio da Responsabilidade Única (SRP)

Este princípio afirma que uma classe deve ter apenas uma razão para mudar, ou seja, deve ter uma única responsabilidade ou função.

**Exemplo:** Pense em um telefone celular. Um telefone celular possui vários componentes como câmera, tela sensível ao toque, alto-falante, etc. Cada um desses componentes tem sua própria função distinta. Aplicando o SRP no código, você criaria classes separadas para cada componente em vez de ter uma única classe que manipula todas as funcionalidades.

```java
// Antes do SRP
class MobilePhone {
    void makeCall() { /* ... */ }
    void takePhoto() { /* ... */ }
    void playMusic() { /* ... */ }
}

// Depois do SRP
class Call {
    void makeCall() { /* ... */ }
}
class Camera {
    void takePhoto() { /* ... */ }
}

class MusicPlayer {
    void playMusic() { /* ... */ }
}
```

## Princípio Aberto/Fechado (OCP)

Este princípio sugere que as classes devem estar abertas para extensão, mas fechadas para modificação. Isso significa que você deve ser capaz de adicionar nova funcionalidade sem alterar o código existente.

**Exemplo:** Considere uma biblioteca de formas geométricas. Em vez de modificar as classes de forma existentes ao adicionar novas formas, você poderia criar uma interface comum para todas as formas e estender essa interface para criar novas formas. Desta forma, o código existente permanece inalterado enquanto novas formas podem ser facilmente adicionadas.

```java
// Antes do OCP
class Circle {
    double radius;

    double area() {
        return Math.PI * radius * radius;
    }
}

// Depois do OCP
interface Shape {
    double area();
}

class Circle implements Shape {
    double radius;

    @Override
    public double area() {
        return Math.PI * radius * radius;
    }
}

class Rectangle implements Shape {
    double width;
    double height;

    @Override
    public double area() {
        return width * height;
    }
}
```

## Princípio de Substituição de Liskov (LSP)

Este princípio enfatiza que objetos de classes derivadas devem ser capazes de substituir objetos de suas classes base sem afetar a correção do programa.

**Exemplo:** Imagine um cenário onde você tem uma classe base “Pássaro” e classes derivadas “Pardal” e “Avestruz”. Se você seguir o LSP, você deve ser capaz de usar qualquer instância de uma classe derivada (por exemplo, “Pardal”) onde uma instância da classe base (“Pássaro”) é esperada, sem causar comportamentos inesperados.

```java
class Bird {
    void fly() { /* ... */ }
}

class Sparrow extends Bird {
    @Override
    void fly() { /* ... */ }
}

class Ostrich extends Bird {
    // Esta classe não sobrescreve fly()
}
```

## Princípio da Segregação de Interfaces (ISP)

Este princípio afirma que os clientes não devem ser forçados a depender de interfaces que não usam. Em outras palavras, mantenha as interfaces pequenas e focadas.

**Exemplo:** Em um aplicativo de mensagens, você pode ter interfaces para enviar, receber e exibir mensagens. Em vez de ter uma única interface grande para todas as operações de mensagens, você dividiria em interfaces menores para que as classes só precisem implementar os métodos relevantes para elas.

```java
// Antes do ISP
interface Messaging {
    void send();
    void receive();
    void display();
}

// Depois do ISP
interface Sender {
    void send();
}

interface Receiver {
    void receive();
}

interface Displayable {
    void display();
}
```

## Princípio da Inversão de Dependência (DIP)

Este princípio incentiva que módulos de alto nível dependam de abstrações (interfaces ou classes abstratas) em vez de implementações concretas. Também sugere que os módulos de baixo nível não devem depender de módulos de alto nível, mas ambos devem depender de abstrações.

**Exemplo:** Suponha que você tenha um aplicativo de reprodução de música. Em vez de ter o módulo de alto nível depender diretamente de formatos de áudio específicos (por exemplo, MP3, WAV), você definiria uma abstração (interface) para reprodução de áudio. O módulo de alto nível dependeria dessa abstração, e as classes de formato de áudio de baixo nível a implementariam.

```java
// Antes do DIP
class MusicPlayer {
    void playMP3() { /* ... */ }
}

class AudioApp {
    private MusicPlayer musicPlayer = new MusicPlayer();

    void playAudio() {
        musicPlayer.playMP3();
    }
}

// Depois do DIP
interface AudioPlayer {
    void play();
}

class MP3Player implements AudioPlayer {
    @Override
    public void play() { /* ... */ }
}

class AudioApp {
    private AudioPlayer audioPlayer;

    AudioApp(AudioPlayer audioPlayer) {
        this.audioPlayer = audioPlayer;
    }

    void playAudio() {
        audioPlayer.play();
    }
}
```

Aplicar esses princípios SOLID em sua base de código pode levar a um software mais modular, mantível e extensível. No entanto, é importante observar que cada princípio nem sempre é uma regra estrita, e pode haver casos em que um compromisso é necessário. O objetivo é encontrar um equilíbrio que atenda às necessidades específicas do seu projeto, enquanto ainda segue o espírito dos princípios.


# Aula 03 - Controllers

[Exercícios Controllers](https://github.com/MicrosoftLearning/20486D-DevelopingASPNETMVCWebApplications/blob/master/Instructions/20486D_MOD04_LAK.md)


# Aula 04 - Views
[AspNetCore MVC](https://dotnet.microsoft.com/en-us/apps/aspnet/mvc)

[Documentação Views](https://learn.microsoft.com/pt-br/aspnet/core/mvc/views/overview)

[Exercícios Views](https://github.com/MicrosoftLearning/20486D-DevelopingASPNETMVCWebApplications/blob/master/Instructions/20486D_MOD05_LAK.md)


[Exporting ViewComponents](https://www.youtube.com/watch?v=VvyKrdavLrs&ab_channel=Asp.NetMonsters)

[Why Should you use ViewComponents instead of Partial Views](https://www.telerik.com/blogs/why-you-should-use-view-components-not-partial-views-aspnet-core)

[Create reusable UI using the Razor class library project in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/razor-pages/ui-class?view=aspnetcore-8.0&tabs=visual-studio)

[Consume ASP.NET Core Razor components from a Razor class library (RCL)](https://learn.microsoft.com/en-us/aspnet/core/blazor/components/class-libraries?view=aspnetcore-8.0&tabs=visual-studio)


[Develop an ASP.NET Core web app that consumes an API](https://learn.microsoft.com/en-us/credentials/applied-skills/develop-an-aspnet-core-web-app-that-consumes-an-api/)


# Aula 05 - Models e Entity Framework

[Documentação Model](https://learn.microsoft.com/pt-br/aspnet/core/tutorials/first-mvc-app/adding-model)

[Adicionar Validações](https://learn.microsoft.com/pt-br/aspnet/core/tutorials/first-mvc-app/validation?view=aspnetcore-8.0)

[Exercícios Models](https://github.com/MicrosoftLearning/20486D-DevelopingASPNETMVCWebApplications/blob/master/Instructions/20486D_MOD06_LAK.md)


[Documentação EF](https://www.entityframeworktutorial.net/efcore/entity-framework-core.aspx)

[Exercícios Entity](https://github.com/MicrosoftLearning/20486D-DevelopingASPNETMVCWebApplications/blob/master/Instructions/20486D_MOD07_LAK.md)