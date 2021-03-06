using UnityEngine;

namespace Assets.Scripts.VCS.Changes
{
    public class PositionChange : ValueChange
    {
        public ChangeType changeType => ChangeType.Position;
        public Vector3 OldValue { get; }
        public Vector3 NewValue { get; protected set; }

        public PositionChange(Vector3 oldScale, Vector3 newScale)
        {
            OldValue = oldScale;
            NewValue = newScale;
        }

        public void SetNewValue(object newValue)
        {
            if(newValue is Vector3 newVec3Value)
            {
                NewValue = newVec3Value;
            }
        }
    }
}
