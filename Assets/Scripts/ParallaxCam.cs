using UnityEngine;
public class ParallaxCam : MonoBehaviour
{
   public float speed;
   void Update()
   {
       transform.position += new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0f)
                             * speed * Time.deltaTime;
   }
}
