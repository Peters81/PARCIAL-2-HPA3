namespace Negocio;
/// <summary>Contrato exclusivo de generación de hashes.</summary>
public interface IHashService { string GenerarHash(string password); }
