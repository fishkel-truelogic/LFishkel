using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFishkel.Data.Daos
{
    public class AccountRepository : AbstractRepository<Account>
    {

        private static AccountRepository repository;

        public static AccountRepository GetRepository()
        {
            if (repository == null) repository = new AccountRepository();
            return repository;
        }
    }
}
