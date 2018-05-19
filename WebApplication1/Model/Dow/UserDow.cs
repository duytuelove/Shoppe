using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
using PagedList;


namespace Model.Dow
{
  public class UserDow
    {

        ShoppeDbContext db = null;

        public UserDow()
        {
            db = new ShoppeDbContext();
        }

        public long Insert(tblUser entity)
        {
            db.tblUsers.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }



        public bool Update(tblUser entity)
        {

            try
            {
                var user = db.tblUsers.Find(entity.ID);
                if (!string.IsNullOrEmpty(entity.Password))
                {
                    user.Password = entity.Password;
                }
                user.Name = entity.Name;
                user.Address = entity.Address;
                user.Email = entity.Email;
                user.ModifiedBy = entity.ModifiedBy;
                user.ModifiedDate = DateTime.Now;
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
            
        }

        public IEnumerable<tblUser> ListAllPaging(int page = 1, int pageSize = 10)
        {
            return db.tblUsers.OrderByDescending(x => x.CreatedDate).ToPagedList(page, pageSize);
         

        }

        public tblUser GetById(string userName)
        {
            return db.tblUsers.SingleOrDefault(x => x.UserName == userName);
        }

        public tblUser ViewDetail(int id)
        {
            return db.tblUsers.Find(id);
        }

        public int Login(string userName, string passWord)
        {
            var resul = db.tblUsers.SingleOrDefault(x => x.UserName == userName);
            if( resul == null)
            {
                return 0;
            }
            else
            {
                if(resul.Status == false)
                {
                    return -1;
                }
                else
                {
                    if (resul.Password == passWord)
                        return 1;
                    else
                        return -2;
                }
            }
        }
        public bool Delete(int id)
        {

            try
            {
                var user = db.tblUsers.Find(id);
                db.tblUsers.Remove(user);
                db.SaveChanges();
                return true;
            }
            catch(Exception ex){
                return false;
            }       
        }
    }
}
