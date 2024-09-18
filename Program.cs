using QBankApi.DTOs;
using QBankApi.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/accounts", () => {

});

app.MapGet("/accounts/{id}", (int id) => {

});

app.MapPost("/accounts", (Account account) => {

});

app.MapPut("/accounts{id}", (int id, Account updatedAccount) => {

});

app.MapDelete("/accounts/{id}", (int id) => {
    
});

app.Run();
