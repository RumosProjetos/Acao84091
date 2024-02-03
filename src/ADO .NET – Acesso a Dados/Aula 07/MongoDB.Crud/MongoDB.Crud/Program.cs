// See https://aka.ms/new-console-template for more information
using MongoDB.ConsoleCrud.Servicos;
using MongoDB.Crud.Modelo;
FamilyService familyService = new FamilyService();

for (int i = 0; i <= 10; i++)
{
    var dados = Util.GenerateData();
    familyService.CriarNovo(dados);
}


var id = familyService.Obter().FirstOrDefault().Id;

var familia = familyService.ObterPorId(id);


var dadosNovos = Util.GenerateData();
dadosNovos.Id = id;
familyService.Atualizar(id, dadosNovos);


familyService.Apagar(id);

