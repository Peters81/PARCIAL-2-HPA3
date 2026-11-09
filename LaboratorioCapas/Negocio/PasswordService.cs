using System.Security.Cryptography;
namespace Negocio;
/// <summary>PBKDF2-SHA256 con sal aleatoria y comparación de tiempo constante.</summary>
public sealed class PasswordService : IHashService, IVerificarHashService
{
    private const int Iteraciones = 600000;
    public string GenerarHash(string password)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(password);
        byte[] salt=RandomNumberGenerator.GetBytes(16);
        byte[] hash=Rfc2898DeriveBytes.Pbkdf2(password,salt,Iteraciones,HashAlgorithmName.SHA256,32);
        return $"PBKDF2-SHA256${Iteraciones}${Convert.ToBase64String(salt)}${Convert.ToBase64String(hash)}";
    }
    public bool Verificar(string password,string hash)
    {
        try {
            var partes=hash.Split('$');
            if(partes.Length!=4 || partes[0]!="PBKDF2-SHA256" ||
                !int.TryParse(partes[1],out int vueltas) || vueltas<100000 || vueltas>2000000) return false;
            var salt=Convert.FromBase64String(partes[2]);
            var esperado=Convert.FromBase64String(partes[3]);
            if(salt.Length!=16 || esperado.Length!=32) return false;
            var actual=Rfc2898DeriveBytes.Pbkdf2(password,salt,vueltas,HashAlgorithmName.SHA256,32);
            return CryptographicOperations.FixedTimeEquals(actual,esperado);
        } catch(FormatException) { return false; }
    }
}
