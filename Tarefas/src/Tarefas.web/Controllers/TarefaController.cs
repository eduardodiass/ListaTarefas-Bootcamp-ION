using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tarefas.web.Models;

namespace Tarefas.web.Controllers
{
    public class TarefaController : Controller
    {
        [HttpPost]
        public IActionResult Create(Tarefa tarefa)
        {

            return View();
        }

    }

    public IActionResult Index()
    {

        var listaDeTarefas = List<Tarefa>();
    }
}