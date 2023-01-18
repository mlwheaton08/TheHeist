namespace TheHeist //instead of {} can have semi-colon at end of this line. looks nicer. (see Roster class for example)
{
    public class TeamMember
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public double CourageLevel { get; set;}

        public override string ToString()
        {
            return "";
        }
    }
}