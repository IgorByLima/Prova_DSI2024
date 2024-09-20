using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoPOO
{
    internal class clsCurso
    {
		private string curso;

		public string Curso
		{
			get { return curso; }
			set { curso = value; }
		}

		private string Sigla;

		public string sigla
		{
			get { return Sigla; }

			set {
				if (value.All(char.IsLetter) && (value.Length > 5))
					Sigla = value;

				else throw new ArgumentException ("No campo SIGLA informe apenas LETRAS, a sigla deve ter no mínimo 5 caracteres");
			    }
			

			}

		private string Nivel;

		public string nivel
		{
			get { return Nivel; }
			set { Nivel = value; }
		}


		private string Periodo;

		public string periodo
		{
			get { return Periodo; }


			set {
				
				if (value.All(char.IsLetter) && value.Length >0)
	
				Periodo = value.ToUpper();

				else throw new FormatException("No campo PERÍODO digite apenas LETRAS");

             
			}
		}
		public void buscarRegistro()
		{
			MessageBox.Show ($"Curso: {curso} Sigla {Sigla} Niver: {Nivel} Período {Periodo}");
		}
		
	}
}
