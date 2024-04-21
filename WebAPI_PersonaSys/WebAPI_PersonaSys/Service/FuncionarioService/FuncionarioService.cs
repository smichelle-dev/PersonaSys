using WebAPI_PersonaSys.DataContext;
using WebAPI_PersonaSys.Models;

namespace WebAPI_PersonaSys.Service.FuncionarioService
{
    public class FuncionarioService : IFuncionarioInterface
    {
        private readonly ApplicationDbContext _context;
        public FuncionarioService(ApplicationDbContext context) {
            _context=context;
        
        }

        public async Task<ServiceResponse<List<FuncionarioModel>>> CreateFuncionario(FuncionarioModel novoFuncionario)
        {
            ServiceResponse<List<FuncionarioModel>> serviceResponse = new ServiceResponse<List<FuncionarioModel>>();

            try
            {
                if (novoFuncionario == null)

                {
                    serviceResponse.Dados=null;
                    serviceResponse.Mensagem="Informar Dados!";
                    serviceResponse.Sucesso=false;

                    return serviceResponse;
                }


                _context.Add(novoFuncionario);
                await _context.SaveChangesAsync();
                serviceResponse.Dados=_context.Funcionarios.ToList();


            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem=ex.Message;
                serviceResponse.Sucesso=false;

            }
            return serviceResponse;
        }

        public  Task<ServiceResponse<List<FuncionarioModel>>> CreateFuncionarioList(FuncionarioModel novoFuncionario)
        {

            throw new NotImplementedException();

        }

        public Task<ServiceResponse<List<FuncionarioModel>>> DeleteFuncionario(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<FuncionarioModel>> GetFuncionarioById(int id)
        {
           ServiceResponse<FuncionarioModel> serviceResponse = new ServiceResponse<FuncionarioModel> ();

            try
            {
                FuncionarioModel funcionario = _context.Funcionarios.FirstOrDefault(x => x.Id == id);
                
                if (funcionario == null) {

                    serviceResponse.Dados= null;
                    serviceResponse.Mensagem = "Usuário não encontrado na base de dados";
                    serviceResponse.Sucesso=false;

                }
                serviceResponse.Dados=funcionario;
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem=ex.Message;
                serviceResponse.Sucesso=false;
            }
            return serviceResponse;


        }

        public async Task<ServiceResponse<List<FuncionarioModel>>> GetFuncionarios()
        {

            ServiceResponse<List<FuncionarioModel>> serviceResponse= new ServiceResponse<List<FuncionarioModel>>();

            try
            {
                serviceResponse.Dados = _context.Funcionarios.ToList();
                if (serviceResponse.Dados.Count==0)
                {
                    serviceResponse.Mensagem="Não foi encontrado nenhum dado no banco de dado";
                }
                
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem=ex.Message;
                serviceResponse.Sucesso=false;
            }
            return serviceResponse;
        }

        

        public Task<ServiceResponse<List<FuncionarioModel>>> InativaFuncionario(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<FuncionarioModel>>> UpdateFuncionario(FuncionarioModel editadoFuncionario)
        {
            throw new NotImplementedException();
        }
    }
}
