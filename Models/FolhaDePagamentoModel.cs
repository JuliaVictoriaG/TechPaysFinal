using iText.Kernel.Pdf;
using iText.Layout.Element;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace TechPays.Models
{
    public class FolhaDePagamentoModel
    {
        [Key]
        public int fp_id { get; set; }
        public string fp_mes { get; set; }
        public string fp_ano { get; set; }
        public double fp_salario_liquido { get; set; }
        public Guid fk_funcionario { get; set; }
        public Guid fk_func_vale_alimentacao { get; set; }

        public Guid fk_func_vale_transporte { get; set; }

        public Guid fk_func_inss { get; set; }
        public Guid fk_func_salario_bruto { get; set; }

        public Guid fk_func_fgts { get; set; }

        public Guid fk_func_nome { get; set; }


        

    }
}

