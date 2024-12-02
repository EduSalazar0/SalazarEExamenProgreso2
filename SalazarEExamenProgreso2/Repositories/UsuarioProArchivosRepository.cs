using Newtonsoft.Json;
using SalazarEExamenProgreso2.Interfaces;
using SalazarEExamenProgreso2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalazarEExamenProgreso2.Repositories
{
    public class UsuarioProArchivosRepository : IUsuarioRepository
    {
        private string _fileName = Path.Combine(FileSystem.AppDataDirectory, "EduardoSalazar_usuario.txt");

        public bool CrearUsuario(Usuario usuario)
        {
            try
            {
                string json_data = JsonConvert.SerializeObject(usuario);
                File.WriteAllText(_fileName, json_data);
                return true;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public Usuario DevuelveUsuario()
        {
            Usuario usuario = new Usuario();
            if (File.Exists(_fileName))
            {
                string json_data = File.ReadAllText(_fileName);
                usuario = JsonConvert.DeserializeObject<Usuario>(json_data);
            }

            return usuario;
        }
    }
}
