using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts.Workspace
{
    class WorkspaceUIEvents : MonoBehaviour
    {
        public static WorkspaceUIEvents instance;

        private void Awake()
        {
            instance = this;
        }

        public UnityEvent<Color, Color> onColorChanged = new UnityEvent<Color, Color>();

        public UnityEvent<Vector3, Vector3> onPositionChanged = new UnityEvent<Vector3, Vector3>();

        public UnityEvent<float, float> onRotationChanged = new UnityEvent<float, float>();

        public UnityEvent<Vector3, Vector3> onScaleChanged = new UnityEvent<Vector3, Vector3>();
    }
}
