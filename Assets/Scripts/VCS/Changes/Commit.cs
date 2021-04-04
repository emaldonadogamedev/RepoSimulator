namespace Assets.Scripts.VCS.Changes
{
    public class Commit
    {
        public Commit(int commitId)
        {
            Id = commitId;
        }

        public readonly int Id;

        public Teammate author;

        public PositionChange positionChange { get; set; }

        public RotationChange rotationChange { get; set; }

        public ScaleChange scaleChange { get; set; }

        public ColorChange colorChange { get; set; }
    }
}
