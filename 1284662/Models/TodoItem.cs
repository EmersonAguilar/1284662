using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1284662.Models
{
    public class TodoItem
    {
        [PrimaryKey, AutoIncrement]
        public int  ID { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public  string FavoriteTeam { get; set; }
    }
}
