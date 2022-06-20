using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookServer.ViewModels.Book
{
    public class GetAllViewModel
    {
        public IEnumerable<GetBookViewModel> Books { get; set; }
    }
}
