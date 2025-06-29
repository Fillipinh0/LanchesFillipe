using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesFillipe.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [Required(ErrorMessage = "Informe o nome do lanche deve ser informado")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2}")]
        [Display(Name = "Nome do Lanche")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A dsescrição do lanche deve ser informado")]
        [StringLength(200, MinimumLength = 20, ErrorMessage = "A descrição deve ter no mínimo {1} e no máximo {2}")]
        [Display(Name = "Descrição do Lanche")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "A dsescrição detalhada do lanche deve ser informado")]
        [StringLength(200, MinimumLength = 20, ErrorMessage = "A descrição detalhada deve ter no mínimo {1} e no máximo {2}")]
        [Display(Name = "Descrição detalhada do Lanche")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "Informe o preço do lanche")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(6,2)")]
        [Range(1,9999.99, ErrorMessage = "O preço deve estar entre 1 e 9999,99")]
        public decimal Preco { get; set; }

        [Display(Name = "Caminho Imagem Normal")]
        [StringLength(600, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImagemUrl { get; set; }

        [Display(Name = "Caminho Imagem Normal")]
        [StringLength(600, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "Preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque {  get; set; }


        public int CategoriaId { get; set; } //Basicamente a Fk
        public virtual Categoria Categoria { get; set; } //Nao add na tabela ma necessario pro mapeamento 
    }
}
