using LFishkel.Data;
using LFishkel.Data.Daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LFishkel.Api.Controllers
{
    public class AccountController : ApiController
    {

        private AccountRepository accountDao;

        public AccountController()
        {
              this.accountDao = AccountRepository.GetRepository();
        }

        public HttpResponseMessage GetAccount(int id)
        {
            var account = new Account();

            return Request.CreateResponse<Account>(HttpStatusCode.OK, account);
        }

        public HttpResponseMessage GetAccount()
        {
            
            var accounts = accountDao.GetAll();

            return Request.CreateResponse<HashSet<Account>>(HttpStatusCode.OK, accounts);
        }

        /*
        public HttpResponseMessage PostAccount()
        {
        }

        public HttpResponseMessage PutAccount() 
        {
        }

        public HttpResponseMessage DeleteAccount()
        {
        }
         */
    }
}
