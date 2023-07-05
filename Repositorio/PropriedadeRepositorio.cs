using TeplanConsultoria.DBConnect;
using TeplanConsultoria.Models;

namespace TeplanConsultoria.Repositorio
{
    public class PropriedadeRepositorio : IPropriedadeRepositorio
    {
        private readonly BancoContext _bancoContext;
        public PropriedadeRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public PropriedadeModel Adicionar(PropriedadeModel propriedade)//gravar no banco
        {
            _bancoContext.Propriedade.Add(propriedade);
            _bancoContext.SaveChanges();
            return propriedade;
//            throw new NotImplementedException();
        }

    }
}
