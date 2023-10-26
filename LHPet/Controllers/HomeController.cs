using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;
using LHPet.models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(01, "Arthur A. Ferreira", "123.456.789-10", "arthur.arthusp@sp.senai.br", "Bob");
        Cliente cliente2 = new Cliente(02, "Davi L.Costa", "123.456.789-10", "davilcosta@sp.senai.br", "Manchinha");
        Cliente cliente3 = new Cliente(03, "Aline A. Machado", "122.456.789-10", "machadoaline@sp.senai.br", "Kiki");
        Cliente cliente4 = new Cliente(04, "Rafael S. Teixeira", "133.456.789-10", "rafaelteixeira@sp.senai.br", "Mario");
        Cliente cliente5 = new Cliente(05, "Gabriel G. Silva", "113.456.789-10", "gabrielsilva@sp.senai.br", "Fish");

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        Fornecedor fornecedor1 = new Fornecedor (01, "C# PET S/A", "14.182.102/0001-00", "c=sharp@pet.org");
        Fornecedor fornecedor2 = new Fornecedor (02, "HTML PET S/A", "14.182.102/0001-00", "c=sharp@pet.org");
        Fornecedor fornecedor3 = new Fornecedor (03, "PYTHON PET S/A", "14.182.102/0001-00", "c=sharp@pet.org");
        Fornecedor fornecedor4 = new Fornecedor (04, "C++ PET S/A", "14.182.102/0001-00", "c=sharp@pet.org");
        Fornecedor fornecedor5 = new Fornecedor (05, "JAVASCRIPT PET S/A", "14.182.102/0001-00", "c=sharp@pet.org");

        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
