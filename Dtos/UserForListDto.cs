using System.Collections.Generic;
using MyAppBack.Models;

namespace MyAppBack.Dtos
{
  public class UserForListDto
  {
    public string UserId { get; set; }
    public string Username { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
    public string PhoneNumber { get; set; }
    public ICollection<Item>? UserLinks { get; set; }
  }
}