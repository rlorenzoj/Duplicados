using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Duplicados
{
    internal class Directorios
    {
        public Dictionary<string, string> Examinar(string strOrigen)
        {
            var retorno = new Dictionary<string, string>();

            // Obtenemos la información de los ficheros existentes en el directorio.
            var ficherosExistentes = Directory.GetFiles(strOrigen);
            foreach (var fichero in ficherosExistentes)
            {
                using (var md5 = MD5.Create())
                {
                    string? resultado = null;
                    using (var stream = File.OpenRead(fichero))
                    {
                        var hash = md5.ComputeHash(stream);
                        resultado = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                    }
                    retorno.Add(fichero, resultado);
                }
            }

            // Obtenemos los directorios que están en este directorio.
            var directoriosExistentes = Directory.GetDirectories(strOrigen);
            foreach(var directorio in directoriosExistentes)
            {
                var rtrn = Examinar(directorio);
                retorno.AddRange(rtrn);
            }

            return retorno;
        }
    }
}
