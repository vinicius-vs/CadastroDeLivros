﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivroLibrary.Models
{
    class LivroBibliotecaModel: LivroBaseModel
    {
        public string Localizacao { get; set; }

        public bool Disponibilidade { get; set; }

    }
}
