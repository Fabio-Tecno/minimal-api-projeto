using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_minimal_api.Dominio.ModelViews
{
   public struct Home
    {
        public string Mensagem { get => "Bem-vindo à API de veículos"; }
        public string Doc { get => "http://localhost:5000/swagger"; } // URL completa
    }
}