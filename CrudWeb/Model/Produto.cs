using System.ComponentModel.DataAnnotations.Schema;

namespace CrudWeb.Model
{
    [Table("Prodtuo")]
    public class Produto
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("Descricao")]
        public string Descricao { get; set; }
    }
}
