using System;
using System.Collections.Generic;
using System.Text;

namespace FluentValidation.Dto.Dto
{
    public class BaseDto
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string CreatedAtString { get; set; }
        public string ModifiedAtString { get; set; }
    }
}
