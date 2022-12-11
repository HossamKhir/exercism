using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        // throw new NotImplementedException("Please implement the (static) Badge.Print() method");
        // string? idString = (id is not null) ? id.ToString() : "";
        department = (department is null) ? "Owner" : department;
        string badge = $"{name} - {department.ToUpper()}";
        if (id is null)
        {
            return badge;
        }
        return $"[{id}] - {badge}";
    }
}
