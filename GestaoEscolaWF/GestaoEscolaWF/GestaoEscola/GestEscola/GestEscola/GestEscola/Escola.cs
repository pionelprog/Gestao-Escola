using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestEscola
{
    public class Curso
    {
        public int CodigoCurso {  get; set; }
        public string NomeCurso { get; set; }
    }

    public class Aluno { 

    public int Numero { get; set;}
    public string Nome { get; set;}
    public string morada { get; set;}
    public string codigopos { get; set;}
    public string localidade { get; set;}
    public string Foto { get; set; }
    public string Curso { get; set; }
    public string Genero { get; set; }
    }

    public class Escola
    {

        public static List<Curso> ListaCursos { get; set;} = new List<Curso>();

        public static List<Aluno> ListaAlunos { get; set;} = new List<Aluno>();
        public static object Curso { get; internal set; }
    }
}
