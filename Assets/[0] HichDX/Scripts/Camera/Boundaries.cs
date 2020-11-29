using UnityEngine;

namespace HichDX
{
    public class Boundaries : MonoBehaviour
    {
        public Camera MainCamera;
        private Vector2 screenBounds;
        private float objectWidth;

        void Start()
        {
            screenBounds = MainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, MainCamera.transform.position.z));
            objectWidth = transform.GetComponent<SpriteRenderer>().bounds.extents.x;
        }

        void LateUpdate()
        {
            Vector3 viewPos = transform.position;
            viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x * -1 + objectWidth, screenBounds.x - objectWidth);
            transform.position = viewPos;
        }
    }
}
