using UnityEngine;

namespace Assets.Scripts.VCS.Changes
{
    public class RotationChange : ValueChange
    {
        public ChangeType changeType => ChangeType.Rotation;

        public float OldValue { get; }
        public float NewValue { get; protected set; }

        public RotationChange(float oldRotation, float newRotation)
        {
            OldValue = oldRotation;
            NewValue = newRotation;
        }

        public void SetNewValue(object newValue)
        {
            if (newValue is float newRotValue)
            {
                NewValue = newRotValue;
            }
        }
    }
}
