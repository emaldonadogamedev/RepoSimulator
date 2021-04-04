using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts
{
    interface IWorkspaceUIResponder : IEventSystemHandler
    {
        void OnPositionChange(Vector3 oldPosition, Vector3 newPosition);

        void OnRotationChange(float oldRotation, float newRotation);

        void OnScaleChange(Vector3 oldScale, Vector3 newScale);

        void OnColorChange(Color oldColor, Color newColor);
    }
}
