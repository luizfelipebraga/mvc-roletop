using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoletopMVC.Models;
using RoletopMVC.Repositories;
using RoletopMVC.ViewModel;

namespace RoletopMVC.Controllers
{
    public class CadastroClienteController : AbstractController
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        public IActionResult index()
        {
            ViewData["NomeView"] =  "CadastroCliente";
            

        return View(new BaseViewModel(){NomeView="CadastroCliente",UsuarioEmail=GetUsuarioSession(),UsuarioNome=GetUsuarioNomeSession()});
        }
            
            public IActionResult CadastrarCliente(IFormCollection form)
            {
                ViewData["Action"] =  "Cadastro";
                try
                {
                    Cliente cliente = new Cliente(form["nome"],form["telefone"],form["senha"] ,form["confimarsenha"],form["email"],DateTime.Parse(form["data-nascimento"]));

                    clienteRepository.Inserir(cliente);
                    
                    return View("Sucesso", new RespostaViewModel($"Cadastro efetuado com sucesso, faça o seu login!"){NomeView="Sucesso",UsuarioEmail=GetUsuarioSession(),UsuarioNome=GetUsuarioNomeSession()});
                }

                catch(Exception e)
                {
                    System.Console.WriteLine(e.StackTrace);
                    return View("Erro", new RespostaViewModel($"Cadastro não efetuado, confira se preencheu os dados corretamente!"){NomeView="Erro",UsuarioEmail=GetUsuarioSession(),UsuarioNome=GetUsuarioNomeSession()});
                } 

        }
    }
}