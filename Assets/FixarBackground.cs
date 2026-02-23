using UnityEngine;

public class FixarBackground : MonoBehaviour
{
    private SpriteRenderer bg;  
  
    void Start()  
    {  
        if (!bg) return;  
        Camera cam = GetComponent<Camera>();  
        cam.orthographicSize = bg.bounds.size.y / 2f;  
        cam.transform.position = new Vector3(bg.bounds.center.x, bg.bounds.center.y, cam.transform.position.z);  
    }
}
