using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace tp_modul9.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        public class Mahasiswa
        {
            public string Nama { get; set; }
            public string Nim { get; set; }
        }

        private static List<Mahasiswa> listMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "Atika Aji Hadiyani", Nim = "2211104003" },
            new Mahasiswa { Nama = "Kholifahdina", Nim = "2211104004" },
            new Mahasiswa { Nama = "Afad Fath Musyarof Halim", Nim = "2211104030" },
            new Mahasiswa { Nama = "Rachmat Taufik", Nim = "2211104028" },
            new Mahasiswa { Nama = "Noor Alam Fauzan", Nim = "2211104031" },
        };

        // GET /api/mahasiswa
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return listMahasiswa;
        }

        // GET /api/mahasiswa/{id}
        [HttpGet("{id}")]
        public ActionResult<Mahasiswa> Get(int id)
        {
            if (id < 0 || id >= listMahasiswa.Count)
                return NotFound();
            return listMahasiswa[id];
        }

        // POST /api/mahasiswa
        [HttpPost]
        public void Post([FromBody] Mahasiswa mhs)
        {
            listMahasiswa.Add(mhs);
        }

        // DELETE /api/mahasiswa/{id}
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (id >= 0 && id < listMahasiswa.Count)
            {
                listMahasiswa.RemoveAt(id);
            }
        }
    }
}