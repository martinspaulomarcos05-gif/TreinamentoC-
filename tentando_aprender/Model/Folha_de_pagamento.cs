namespace tentando_aprender.Model;
public class Folha_de_pagamento
{
    public int Id { get; set; }

    public string Cpf { get; set; } = string.Empty;
    public int Mes { get; set; }
    public int Ano { get; set; }
    public double HorasTrabalhadas { get; set; }
    public double ValorHora { get; set; }
    
    public double SalarioBruto { get; set; }
    public double ImpostoRenda { get; set; }
    public double Inss { get; set; } 
}