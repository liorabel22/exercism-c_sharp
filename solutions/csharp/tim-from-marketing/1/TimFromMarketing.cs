static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
            return $"{(id >= 0 ? $"[{id}] - " : "")}{(name ?? "")} - {(department?.ToUpper() ?? "OWNER")}";
    }
}
