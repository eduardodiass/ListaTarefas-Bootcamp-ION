using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;


namespace Tarefas.web.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        [DisplayName("Titulo")]
        public string? Titulo { get; set; }

        [DisplayName("Descricao")]
        public string? Descricao { get; set; }

        [DisplayName("Concluida")]
        public bool IsDone { get; set; }
    }
}