using System;
using Microsoft.EntityFrameworkCore;

namespace api.Data;

public class DataContext(DbContextOptions options) : DbContext(options)
{
}
