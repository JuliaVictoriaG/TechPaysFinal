using System.ComponentModel.DataAnnotations;

namespace TechPays.Models
{
    public class EmpresaModel
    {
        [Key]
        public int empr_id { get; set; }
        public string? empr_nome { get; set; }
        public string? empr_razao_social { get; set; }
        public string? empr_cnpj { get; set; }
        public string? empr_cnae { get; set; }
        public string? empr_endereco { get; set; }
        public string? empr_bairro { get; set; }
        public int empr_end_numero { get; set; }

        public string? empr_telefone { get; set; }
        public string? empr_insc_municipal { get; set; }
        public string? empr_insc_estadual { get; set; }
    }
}
