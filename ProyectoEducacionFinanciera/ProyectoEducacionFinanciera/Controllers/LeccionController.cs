using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoEducacionFinanciera.Data;
using static System.Collections.Specialized.BitVector32;

namespace ProyectoEducacionFinanciera.Controllers
{
    public class LeccionController : Controller
    {
        private readonly DbProyectoContext _context;
        public LeccionController(DbProyectoContext context)
        {
            _context = context;
        }

    }
}
