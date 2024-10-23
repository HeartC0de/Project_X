namespace Domain.DomainEntity;

public class StudentsGroup
{
    private StudentsGroup(string GroupName, Guid GroupGuid, List<Guid UserGuid> StudentsGuids)
    {
        this.GroupName = GroupName;
        this.GroupGuid = GroupGuid;
        this.StudentsGuids = StudentsGuids;
    }

    public string GroupName { get; private set } = string.Empty;
    public Guid GroupGuid { get; private set; }
    List<Guid UserGuid> StudentsGuids = new List<Guid, UserGuid>();

    /// <summary>
    /// Требуется уточнение
    /// </summary>
    /// <returns></returns>
    public static StudentsGroup AddStudent(Guid StudentGuid)
    {
        StudentGuids.Add(StudentGuid);
        return StudentGuid;
    }
}
