using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HichDX
{
    public class DestroyBlocks : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Blocks"))
            {
                Destroy(collision.gameObject);
            }
        }
    }
}
