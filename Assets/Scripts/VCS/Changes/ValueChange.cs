using System;

namespace Assets.Scripts.VCS.Changes
{
    public enum ChangeType
    {
        Position,
        Rotation,
        Scale,
        Color
    }

    public interface ValueChange
    {
        public ChangeType changeType { get; }

        public void SetNewValue(object newValue);
    }
}
