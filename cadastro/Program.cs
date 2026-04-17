using cadastro.Models;

var builder = WebApplication.CreateBuilder(args);

// Define o endereço e a porta em que a aplicação irá escutar requisições HTTP
builder.WebHost.UseUrls("http://localhost:8000");

// Constrói a aplicação web a partir das configurações definidas no builder
var app = builder.Build();

// Definição de rotas HTTP do tipo GET 
app.MapGet("/", () => "API funcionando com ASP.NET!");

app.MapGet("/for", () =>
{
    for(int i = 0; i < 5; i++) {
        Console.WriteLine(i);
    }
});

app.MapGet("/while", () =>
{
    int i = 0;
    while(i < 5){
        Console.WriteLine(i);
        i++;
    }
});

app.MapGet("/objeto/{nome}", (string nome) => {
    Funcionario funcionario = new Funcionario();

    funcionario.Nome = nome;

    Console.WriteLine("Nome: " + funcionario.Nome);
    return Results.Ok(new {
        nome
    });

});

app.Run();
