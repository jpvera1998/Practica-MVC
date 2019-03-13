using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.Capas.Entity
{
    public class TerritorieVM
    {


        [Required]
        [StringLength(50)]
        public string TerritoryDescription { get; set; }

        private bool selected;

        public Boolean IsSelected
        {
            get => selected = false;
            set => selected = true;
        }

    }
}
