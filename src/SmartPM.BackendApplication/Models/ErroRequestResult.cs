using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartPM.BackendApplication.Models
{
    public class ErroRequestResult
    {
        public bool Erro { get; set; } = false;
        public string Message { get; set; } = null;
    }
}
