namespace eShopCmc.Domain.Countries;

public interface ICountryRepository
{
    Task<List<Country>> GetCountriesAsync(CancellationToken ct);
}
