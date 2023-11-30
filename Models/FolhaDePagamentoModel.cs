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


        //public void GerarFolhaPagamentoPDF()
        //{
        //    string filePath = "FolhaPagamento.pdf";

        //    using (var writer = new PdfWriter(filePath))
        //    {
        //        using (var pdf = new PdfDocument(writer))
        //        {
        //            var document = new Document(pdf);

        //            // Adiciona conteúdo ao PDF
        //            document.Add(new Paragraph("Folha de Pagamento"));

        //            document.Add(new Paragraph($"Nome do Funcionário: {fk_func_nome}"));
        //            document.Add(new Paragraph($"CPF: {fk_func_cpf}"));
        //            document.Add(new Paragraph($"Cargo: {fk_func_cargo}"));
        //            document.Add(new Paragraph($"Salário Bruto: R${fk_func_salario_bruto}"));
        //            document.Add(new Paragraph($"Descontos: R${Descontos}"));
        //            document.Add(new Paragraph($"Salário Líquido: R${fp_salario_liquido}"));

        //            document.Add(new Paragraph($"Nome da Empresa: {NomeEmpresa}"));
        //            document.Add(new Paragraph($"CNPJ da Empresa: {CNPJEmpresa}"));
        //            document.Add(new Paragraph($"Endereço da Empresa: {EnderecoEmpresa}"));
        //        }
        //    }

        //    Console.WriteLine($"Folha de pagamento salva em: {Path.GetFullPath(filePath)}");
        //}

    }
}

