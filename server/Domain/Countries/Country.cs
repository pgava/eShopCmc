namespace eShopCmc.Domain.Countries;

public class Country
{
    public CountryId Id { get; set; }
    public string CountryName { get; set; }
    public string CurrencyCode { get; set; }
    public string CurrencySymbol { get; set; }
    public decimal ExchangeRate { get; set; }
}
