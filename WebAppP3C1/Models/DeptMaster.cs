using System.ComponentModel.DataAnnotations;

namespace WebAppP3C1.Models
{
    public class DeptMaster
    {
        [Key]
        public int DeptCode { get; set; }
        public string DeptName { get; set; }
       
    }
}
