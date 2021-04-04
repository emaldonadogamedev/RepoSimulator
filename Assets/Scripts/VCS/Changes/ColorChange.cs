using UnityEngine;

namespace Assets.Scripts.VCS.Changes
{
    public class ColorChange : ValueChange
    {
        public ChangeType changeType => ChangeType.Color;
        public Color OldValue { get; }
        public Color NewValue { get; protected set; }

        public ColorChange(Color oldRotation, Color newRotation)
        {
            OldValue = oldRotation;
            NewValue = newRotation;
        }

        public void SetNewValue(object newValue)
        {
            if (newValue is Color newColorValue)
            {
                NewValue = newColorValue;
            }
        }
    }
}
