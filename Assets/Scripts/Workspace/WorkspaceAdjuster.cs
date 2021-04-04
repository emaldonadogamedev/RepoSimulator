using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Assets.Scripts.Workspace;

namespace Assets.Scripts.VCS.Workspace
{
    public class WorkspaceAdjuster : MonoBehaviour, IWorkspaceUIResponder
    {
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

        public void OnColorChange(Color oldColor, Color newColor)
        {
            workspaceGOspriteRenderer.color = newColor;
        }

        public void OnPositionChange(Vector3 oldPosition, Vector3 newPosition)
        {
            workspaceGameObject.transform.position = newPosition;
        }

        public void OnRotationChange(float oldRotation, float newRotation)
        {
            workspaceGameObject.transform.Rotate(Vector3.forward, newRotation);
        }

        public void OnScaleChange(Vector3 oldScale, Vector3 newScale)
        {
            workspaceGameObject.transform.localScale = newScale;
        }
    }
}