using SalazarEExamenProgreso2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalazarEExamenProgreso2.Interfaces
{
    public interface IUsuarioRepository
    {
        bool CrearUsuario(Usuario usuario);
        Usuario DevuelveUsuario();

    }
}
