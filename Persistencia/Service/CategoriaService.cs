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

                } else if ((nome != "") && (valor != ""))
                {
                    
                    Categoria categoria = new Categoria();

                    categoria.Nome = nome;
                    categoria.Valor = decimal.Parse(valor);
                    categoria.Status = 1;
                    long resultado = categoriaDAO.Inserir(categoria);
                    if (resultado != -1)
                    {
                        MessageBox.Show("Categoria inserida com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro.");
                    }
                  
                    
                } else
                {
                    return -1;
                }

            }
            if (result1 == DialogResult.Cancel)
            {

            }
            return -1;
        }
    }
}
    

