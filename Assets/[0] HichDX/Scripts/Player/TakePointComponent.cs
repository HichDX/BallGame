using UnityEngine;

namespace HichDX
{
    public class TakePointComponent : Singleton<TakePointComponent>
    {
        private int _point = 0;

        public delegate void PointAction(int point);

        public event PointAction pointAction;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Point"))
            {
                Destroy(collision.gameObject);
                _point++;
                pointAction.Invoke(_point);               
            }
        }
    }
}
