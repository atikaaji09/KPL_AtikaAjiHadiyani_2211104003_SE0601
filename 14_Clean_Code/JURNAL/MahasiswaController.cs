using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace modul14_2211104003.Controllers
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

        private static readonly List<Mahasiswa> _mahasiswaList = new()
        {
            new Mahasiswa { Nama = "Atika Aji Hadiyani", Nim = "2211104003" },
            new Mahasiswa { Nama = "Kholifahdina", Nim = "2211104004" },
            new Mahasiswa { Nama = "Afad Fath Musyarof Halim", Nim = "2211104030" },
            new Mahasiswa { Nama = "Rachmat Taufik", Nim = "2211104028" },
            new Mahasiswa { Nama = "Noor Alam Fauzan", Nim = "2211104031" }
        };

        // GET: api/mahasiswa
        [HttpGet]
        public ActionResult<IEnumerable<Mahasiswa>> GetAllMahasiswa()
        {
            return Ok(_mahasiswaList);
        }

        // GET: api/mahasiswa/{id}
        [HttpGet("{id}")]
        public ActionResult<Mahasiswa> GetMahasiswaById(int id)
        {
            if (id < 0 || id >= _mahasiswaList.Count)
            {
                return NotFound();
            }
            return Ok(_mahasiswaList[id]);
        }

        // POST: api/mahasiswa
        [HttpPost]
        public ActionResult AddMahasiswa([FromBody] Mahasiswa mahasiswa)
        {
            _mahasiswaList.Add(mahasiswa);
            return CreatedAtAction(nameof(GetMahasiswaById), new { id = _mahasiswaList.Count - 1 }, mahasiswa);
        }

        // DELETE: api/mahasiswa/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteMahasiswa(int id)
        {
            if (id < 0 || id >= _mahasiswaList.Count)
            {
                return NotFound();
            }

            _mahasiswaList.RemoveAt(id);
            return NoContent();
        }
    }
}