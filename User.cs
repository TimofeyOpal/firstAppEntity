using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace firstAppEntity
{
    class User
    {
        [Key] //валидация 
       public int Id { get; set; }
       public string Name { get; set; }
       public int Age { get; set; }

    }
}
