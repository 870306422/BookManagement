using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BookManagement.Models;

namespace BookManagement.Controllers
{
    public class BManageController : ApiController
    {
        /// <summary>
        /// 飙升榜
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Soaringlist> list()
        {
            using (BookManagementDBEntities db = new BookManagementDBEntities())
            {
                return db.Soaringlist.ToList();
            }
        }
        /// <summary>
        /// 飙升榜
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Newbook> ListtList()
        {
            using (BookManagementDBEntities db = new BookManagementDBEntities())
            {
                return db.Newbook.ToList();
            }
        }
        /// <summary>
        /// 飙升榜
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Totallist> ListtrList()
        {
            using (BookManagementDBEntities db = new BookManagementDBEntities())
            {
                return db.Totallist.ToList();
            }
        }
        /// <summary>
        /// 飙升榜
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Updatebook> ListFList()
        {
            using (BookManagementDBEntities db = new BookManagementDBEntities())
            {
                return db.Updatebook.ToList();
            }
        }
    }
}
