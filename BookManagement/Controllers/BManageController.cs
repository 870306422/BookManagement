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
        #region 榜单总数
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
        /// 新书榜
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
        /// 总榜
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
        /// 更新榜
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
        #endregion

        #region 增加
        /// <summary>
        /// 飙升榜增加
        /// </summary>
        /// <param name="soaringlist">传值</param>
        /// <returns></returns>
        [HttpPost]
        public bool Add(Soaringlist soaringlist)
        {
            using (BookManagementDBEntities db = new BookManagementDBEntities())
            {
                db.Soaringlist.Add(soaringlist);
                return db.SaveChanges() > 0;
            }
        }
        /// <summary>
        /// 新书榜增加
        /// </summary>
        /// <param name="newbook"></param>
        /// <returns></returns>
        [HttpPost]
        public bool AddOne(Newbook newbook)
        {
            using (BookManagementDBEntities db = new BookManagementDBEntities())
            {
                db.Newbook.Add(newbook);
                return db.SaveChanges() > 0;
            }
        }
        /// <summary>
        /// 总榜增加
        /// </summary>
        /// <param name="totallist"></param>
        /// <returns></returns>
        [HttpPost]
        public bool AddTwo(Totallist totallist)
        {
            using (BookManagementDBEntities db = new BookManagementDBEntities())
            {
                db.Totallist.Add(totallist);
                return db.SaveChanges() > 0;
            }
        }
        /// <summary>
        /// 更新榜增加
        /// </summary>
        /// <param name="updatebook"></param>
        /// <returns></returns>
        [HttpPost]
        public bool AddTh(Updatebook updatebook)
        {
            using (BookManagementDBEntities db = new BookManagementDBEntities())
            {
                db.Updatebook.Add(updatebook);
                return db.SaveChanges() > 0;
            }
        }
        #endregion

        #region 修改
        /// <summary>
        /// 飙升榜修改
        /// </summary>
        /// <param name="soaringlist">传值</param>
        /// <returns></returns>
        [HttpPut]
        public bool Create(Soaringlist soaringlist)
        {
            using (BookManagementDBEntities db = new BookManagementDBEntities())
            {
                db.Entry(soaringlist).State = System.Data.Entity.EntityState.Modified;
                return db.SaveChanges() > 0;
            }
        }
        /// <summary>
        /// 新书榜修改
        /// </summary>
        /// <param name="newbook"></param>
        /// <returns></returns>
        [HttpPut]
        public bool CreateOne(Newbook newbook)
        {
            using (BookManagementDBEntities db = new BookManagementDBEntities())
            {
                db.Entry(newbook).State = System.Data.Entity.EntityState.Modified;
                return db.SaveChanges() > 0;
            }
        }
        /// <summary>
        /// 总榜修改
        /// </summary>
        /// <param name="totallist"></param>
        /// <returns></returns>
        [HttpPut]
        public bool CreateTwo(Totallist totallist)
        {
            using (BookManagementDBEntities db = new BookManagementDBEntities())
            {
                db.Entry(totallist).State = System.Data.Entity.EntityState.Modified;
                return db.SaveChanges() > 0;
            }
        }
        /// <summary>
        /// 更新榜修改
        /// </summary>
        /// <param name="updatebook"></param>
        /// <returns></returns>
        [HttpPut]
        public bool CreateTh(Updatebook updatebook)
        {
            using (BookManagementDBEntities db = new BookManagementDBEntities())
            {
                db.Entry(updatebook).State = System.Data.Entity.EntityState.Modified;
                return db.SaveChanges() > 0;
            }
        }
        #endregion

        #region 删除
        /// <summary>
        /// 飙升榜删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public bool DeleteT(Soaringlist id)
        {
            using (BookManagementDBEntities db = new BookManagementDBEntities())
            {
                var obj = db.Soaringlist.Find(id.S_Id);
                db.Soaringlist.Remove(obj);
                return db.SaveChanges() > 0;
            }
        }
        /// <summary>
        /// 新书榜删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public bool DeleteOne(Newbook id)
        {
            using (BookManagementDBEntities db = new BookManagementDBEntities())
            {
                var obj = db.Newbook.Find(id.N_Id);
                db.Newbook.Remove(obj);
                return db.SaveChanges() > 0;
            }
        }
        /// <summary>
        /// 总榜删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public bool DeleteTwo(Totallist id)
        {
            using (BookManagementDBEntities db = new BookManagementDBEntities())
            {
                var obj = db.Totallist.Find(id.T_Id);
                db.Totallist.Remove(obj);
                return db.SaveChanges() > 0;
            }
        }
        /// <summary>
        /// 更新榜删除
        /// </summary>
        /// <param name="id">更新榜主键</param>
        /// <returns></returns>
        [HttpDelete]
        public bool DeleteTh(Updatebook id)
        {
            using (BookManagementDBEntities db = new BookManagementDBEntities())
            {
                var obj = db.Updatebook.Find(id.U_Id);
                db.Updatebook.Remove(obj);
                return db.SaveChanges() > 0;
            }
        }
        #endregion

    }
}
