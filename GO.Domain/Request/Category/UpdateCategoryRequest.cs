using System;
using System.Collections.Generic;
using System.Text;

namespace GO.Domain.Request.Category
{
    public class UpdateCategoryRequest
    {
        public int IdCategory { get; set; }
        public string CategoryName { get; set; }
    }
}
