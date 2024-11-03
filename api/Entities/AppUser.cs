using System;

namespace api.Entities;

public class AppUser // in EF AppUser will be a table in the database
{
  public int Id { get; set; } // default value of int is 0

  // use pascale case for properties. in c#11 you can use required keyword to make it required
  // if nullable is not used, the default value will be null
  public required string UserName { get; set; }

}
