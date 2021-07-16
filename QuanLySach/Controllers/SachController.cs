using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuanLySach.Models;

namespace QuanLySach.Controllers
{
    public class SachController : ApiController
    {
        Sach[] sachs = new Sach[]
        {
            new Sach {Id = 1, Title = "Tôi thấy hôm này mình nắng cực", AuthorName = "Tô Thanh Tâm", Content = "Truyện kể về thằng trẻ trâu,...", Price = 1},

            new Sach {Id = 2, Title = "Tôi thấy hôm này mình đẹp cực", AuthorName = "Tô Thanh Tâm", Content = "Truyện kể về thằng trẻ trâu tự luyến bản thân,...", Price = 3},
        };

        public IEnumerable<Sach> GetAll()
        {
            return sachs;
        }

        public IHttpActionResult GetSach(int id)
        {
            var sach = sachs.FirstOrDefault((p) => p.Id == id);
            if (sach == null)
            {
                return NotFound();
            }
            return Ok(sach);
        }
    }
}
