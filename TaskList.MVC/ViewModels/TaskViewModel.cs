using System;
using System.ComponentModel.DataAnnotations;

namespace TaskList.MVC.ViewModels
{
    public class TaskViewModel
    {
        [Key]
        public int TaskId { get; set; }
        
        [Display(Name = "Task conluida")]
        public bool Concluida { get; set; }

        [Display(Name = "Task excluída")]
        public bool Excluida { get; set; }

        [Required(ErrorMessage = "Campo título é obrigatório. ")]
        [MaxLength(200, ErrorMessage = "Máximo {1} caracteres.")]
        [MinLength(5, ErrorMessage = "Minimo {1} caracteres. ")]
        [Display(Name = "Título")]
        public string Titulo { get; set; }

        [DataType(DataType.MultilineText)]
        [MaxLength(1500, ErrorMessage = "Máximo {1} caracteres.")]
        [MinLength(10, ErrorMessage = "Minimo {1} caracteres. ")]
        public string Descricao { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy hh:mm}")]
        [Display(Name = "Data Criação")]
        public DateTime? DtCriacao { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy hh:mm}")]
        [Display(Name = "Data Edição")]
        public DateTime? DtEdicao { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy hh:mm}")]
        [Display(Name = "Data Exclusão")]
        public DateTime? DtExclusao { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy hh:mm}")]
        [Display(Name = "Data Conclusão")]
        public DateTime? DtConclusao { get; set; }
    }
}