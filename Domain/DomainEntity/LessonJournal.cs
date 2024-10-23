namespace Domain.DomainEntity;

public class LessonJournal
{
    private LessonJournal(Guid SubjectGuid, DateTime TimeStamp, Guid GroupGuid, Dictionary<Guid, short> Students)
    {
        this.SubjectGuid = SubjectGuid;
        this.TimeStamp = TimeStamp;
        this.GroupGuid = GroupGuid;

    }

    public Guid SubjectGuid { get; set; }
    public DateTime TimeStamp { get; set; }
    public Guid GroupGuid { get; private set; }
    //Уточнить
    Dictionary<Guid, short> Students { get; private set; } = new Dictionary<Guid, short>();

    public static LessonJournal Create(Guid SubjectGuid, DateTime TimeStamp, Guid GroupGuid, Dictionary<Guid, short> Students)
    {
        return new LessonJournal(subjectGuid, subjectName, teacherGuid);
    }
}
