namespace Negocio;
/// <summary>Contrato exclusivo de verificación de hashes.</summary>
public interface IVerificarHashService { bool Verificar(string password, string hash); }
