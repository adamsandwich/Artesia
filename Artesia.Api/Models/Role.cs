using System.Collections.Generic;
namespace Artesia.Model
{
    public class Role
    {
        public int id { get; set; }
        public string RoleName { get; set; }
        public List<string> Permission { get; set; }
    }
}