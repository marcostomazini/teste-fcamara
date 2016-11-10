using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Angle_MVC6_Angular_Seed.Models
{    
    /// <summary>
    ///     Entidade Base
    /// </summary>
    public class Entidade    
    {
    	[Key]
    	public int Id  { get; set; }        

		[Required]
    	public DateTime DataInclusao { get; set; }

    	public DateTime? DataAlteracao { get; set; }
    }
}
