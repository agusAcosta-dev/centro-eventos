using System;
using System.Security.Cryptography;
using System.Text;

namespace CentroEventos.Aplicacion.Clases;

public class Hasher
{
    public static string Sha265(string contra)
    {
        if (String.IsNullOrWhiteSpace(contra)) throw new ValidacionException("Todos los datos deben ser rellenados.");
        using var sha = SHA256.Create();
        byte[] bytes = Encoding.UTF8.GetBytes(contra);
        byte[] hash = sha.ComputeHash(bytes);
        return Convert.ToBase64String(hash);
    }
}
