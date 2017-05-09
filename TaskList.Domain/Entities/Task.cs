using System;

namespace TaskList.Domain.Entities
{
    public class Task
    {
        public int TaskId { get; set; }

        public bool Concluida { get; set; }

        public bool Excluida { get; set; }
        
        public string Titulo { get; set; }
        public string Descricao { get; set; }

        public DateTime? DtCriacao { get; private set; }
        public DateTime? DtEdicao { get; private set; }
        public DateTime? DtExclusao { get; set; }
        public DateTime? DtConclusao { get; set; }
    }
}
