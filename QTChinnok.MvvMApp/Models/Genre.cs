using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTChinnok.MvvMApp.Models
{
    public class Genre : ModelObject
    {
        public Genre()
        {

        }
        public Genre(Logic.Models.Base.Genre entity)
        {
            Id = entity.Id;
            Name = entity.Name ?? string.Empty;
        }
        public string Name { get; set; } = string.Empty;
        public override string ToString() => $"{Name}";
    }
}
