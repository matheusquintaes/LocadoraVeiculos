using Persistencia.DAO;
using Persistencia.Modelo;
using System.Windows.Forms;

namespace Persistencia.Service
{

    public class CategoriaService
    {
        private CategoriaDAO categoriaDAO;
        public CategoriaService()
        {
            categoriaDAO = new CategoriaDAO();
        }
        public long Inserir(string nome, string valor)
        {
            DialogResult result1 = MessageBox.Show("Deseja salvar o novo cadastro?",
              "Salvar novo cadastro",
              MessageBoxButtons.OKCancel,
              MessageBoxIcon.Question);
            if (result1 == DialogResult.OK)
            {
                if (nome == "" && valor == "")
                {
                    MessageBox.Show("Preencha corretamente as informações");
                }

                if ((nome != "") && (valor != ""))
                {
                    Categoria categoria = new Categoria();

                    categoria.Nome = nome;
                    categoria.Valor = decimal.Parse(valor);
                    categoria.Status = 1;
                    return categoriaDAO.Inserir(categoria);
                    MessageBox.Show("Categoria Inserida com Sucesso");
                }



            }
            if (result1 == DialogResult.Cancel)
            {

            }
            return -1;
        }
    }
}
    

