using UnityEngine;

using Assets.Scripts.Workspace;
using Assets.Scripts.VCS.Changes;

namespace Assets.Scripts.VCS
{
    class CurrentCommitManager : MonoBehaviour, IWorkspaceUIResponder
    {
        Commit currentCommit;
        GameObject workspaceGameObject;
        SpriteRenderer workspaceGOspriteRenderer;

        void Start()
        {
            workspaceGameObject = GameObject.Find("The GameObject");
            workspaceGOspriteRenderer = workspaceGameObject.GetComponent<SpriteRenderer>();

            WorkspaceUIEvents.instance.onColorChanged.AddListener(OnColorChange);
            WorkspaceUIEvents.instance.onPositionChanged.AddListener(OnPositionChange);
            WorkspaceUIEvents.instance.onRotationChanged.AddListener(OnRotationChange);
            WorkspaceUIEvents.instance.onScaleChanged.AddListener(OnScaleChange);
        }

        public void ResetOriginalState()
        {

        }

        public void OnColorChange(Color oldColor, Color newColor)
        {
            currentCommit.colorChange = new ColorChange(oldColor, newColor);
        }

        public void OnPositionChange(Vector3 oldPosition, Vector3 newPosition)
        {
            currentCommit.positionChange = new PositionChange(oldPosition, newPosition);
        }

        public void OnRotationChange(float oldRotation, float newRotation)
        {
            currentCommit.rotationChange = new RotationChange(oldRotation, newRotation);
        }

        public void OnScaleChange(Vector3 oldScale, Vector3 newScale)
        {
            workspaceGameObject.transform.localScale = newScale;
        }
    }
}
