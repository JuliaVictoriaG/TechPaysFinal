using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

using Microsoft.AspNetCore.Routing;
using System.ComponentModel.DataAnnotations;

namespace TechPays.Models
{
    public class FuncionarioModel
    {
        public int func_usuario { get; set; }
        [Key]
        public int func_id { get; set; }
        [Required(ErrorMessage = "Digite o nome do funcionário")]
        public string func_nome { get; set; }
        [Required(ErrorMessage = "Digite o departamento do funcionário")]
        public string func_departamento { get; set; }
        [Required(ErrorMessage = "Digite o cargo do funcionário")]
        public string func_cargo { get; set; }
        [Required(ErrorMessage = "Digite o CPF do funcionário")]
        public string func_cpf { get; set; }

        public virtual List<LoginModel> Logins { get; set; }
        [Required(ErrorMessage = "Digite o RG do funcionário")]
        public string func_rg { get; set; }
        [Required(ErrorMessage = "Digite o endereço do funcionário")]
        public string func_endereco { get; set; }
        [Required(ErrorMessage = "Digite o bairro")]
        public string func_bairro { get; set; }
        [Required(ErrorMessage = "Digite o numero da rua ")]
        public int func_end_numero { get; set; }
        [Required(ErrorMessage = "Digite o celular do funcionário")]
        public string func_celular { get; set; }
        [Required(ErrorMessage = "Digite o estado")]
        public string func_estado { get; set; }
        [Required(ErrorMessage = "Digite a cidade")]
        public string func_cidade { get; set; }
        [Required(ErrorMessage = "Digite o CEP")]
        public string func_cep { get; set; }
        [Required(ErrorMessage = "Digite o E-mail funcionário")]
        public string func_email { get; set; }

        [Required(ErrorMessage = "Digite o salário do funcionário")]
        public decimal func_salario_bruto { get; set; }
        public decimal? func_salario_liquido { get; set; }
        public decimal func_inss { get; set; }
        public decimal func_fgts { get; set; }
        [Required(ErrorMessage = "Digite a data de admissão do funcionário")]
        public DateTime func_dt_admissao { get; set; }
        [Required(ErrorMessage = "Digite a carga horária do funcionário")]
        public int func_hora_trab { get; set; }

        [Required(ErrorMessage = "Digiteo número da carteira de trabalho do funcionário")]
        public string func_ctps { get; set; }
        public decimal func_vale_transporte { get; set; }
        public decimal? func_vale_alimentacao { get; set; }
        public int? UsuarioId { get; set; }

        public UsuarioModel Usuario { get; set; }

      

        public void GerarFolhaPagamentoPDF()
        {
            string filePath = $"FolhaPagamento.{DateTime.Now.ToString("yyyy.MM.dd.HH.mm.ss")}..pdf";
           
          
                using (var writer = new PdfWriter(filePath))
            {
                using (var pdf = new PdfDocument(writer))
                {
                    var document = new Document(pdf);
                   
                    

                    // Adiciona conteúdo ao PDF
                    document.Add(new Paragraph("Folha de Pagamento"));
                    document.Add(new Paragraph($"TechPays Serviços de Automatização Ltda."));
                    document.Add(new Paragraph($"17.037.433/0001-14 "));
                    document.Add(new Paragraph($"Rua Luciana Maria Machado"));
                    document.Add(new Paragraph($"Mês de Referência: 10"));

                    document.Add(new Paragraph($"Nome do Funcionário: {func_nome}"));
                    document.Add(new Paragraph($"Data de Admissão: {func_dt_admissao}"));
                    document.Add(new Paragraph($"Cargo: {func_cargo}"));
                    document.Add(new Paragraph($"Salário Bruto: R${func_salario_bruto}"));
                    document.Add(new Paragraph($"Descontos: R${func_vale_transporte}"));
                    document.Add(new Paragraph($"Descontos: R${func_fgts}"));
                    document.Add(new Paragraph($"Descontos: R${func_inss}"));
                    document.Add(new Paragraph($"Salário Líquido: R${func_salario_liquido}"));

                    document.Close();
                }

            }

            Console.WriteLine($"Folha de pagamento salva em: {Path.GetFullPath(filePath)}");
        }

    }
    
}
