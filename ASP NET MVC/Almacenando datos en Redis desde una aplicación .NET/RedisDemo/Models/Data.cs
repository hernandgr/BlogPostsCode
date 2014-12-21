using System.ComponentModel.DataAnnotations;
namespace RedisDemo.Models
{
    public class Data
    {
        [Required]
        public string Key { get; set; }

        public string Value { get; set; }

        public string Message { get; set; }
    }
}