using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto3emcamadas.Code.DTO
{
    class PostDTO
    {
        private string _Titulo, _Constesto;
        private int _id;

        public string Titulo { get => _Titulo; set => _Titulo = value; }
        public string Constesto { get => _Constesto; set => _Constesto = value; }
        public int Id { get => _id; set => _id = value; }
    }
}
