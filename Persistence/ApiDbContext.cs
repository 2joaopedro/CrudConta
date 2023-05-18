using CrudConta.Entities;

namespace CrudConta.Persistence
{
    public class ApiDbContext
    {
        public List<Conta> Conta {get; set;}

        public ApiDbContext()
        {
            Conta = new List<Conta>();
        }
    }
}