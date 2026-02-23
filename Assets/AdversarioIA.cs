using UnityEngine;

public class AdversarioIA : MonoBehaviour
{
    public Transform puck;  
    public float maxSpeed = 6f;  
    public Camera cam;  
  
    Rigidbody2D rb;  
  
    void Awake()  
    {  
        rb = GetComponent<Rigidbody2D>();  
        if (!cam) cam = Camera.main;  
    }  
  
    void FixedUpdate()  
    {  
        if (!puck) return;  
  
        float vert = cam.orthographicSize;  
        float horiz = vert * cam.aspect;  
        float centerX = cam.transform.position.x;  
  
        Vector2 target = new Vector2(  
            centerX + horiz * 0.5f, 
            puck.position.y  
        );  
  
        target.x = Mathf.Clamp(target.x, centerX, cam.transform.position.x + horiz);  
        target.y = Mathf.Clamp(target.y, cam.transform.position.y - vert, cam.transform.position.y + vert);  
  
        Vector2 newPos = Vector2.MoveTowards(rb.position, target, maxSpeed * Time.fixedDeltaTime);  
        rb.MovePosition(newPos);  
    }
}
