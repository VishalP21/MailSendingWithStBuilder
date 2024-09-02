using System;
using System.Collections.Generic;

namespace Student.Database;

public partial class StudentMaildetail
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public int? PhoneNumber { get; set; }
}
