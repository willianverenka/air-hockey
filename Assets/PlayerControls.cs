using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        Camera cam = Camera.main;  
        Vector3 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        float velMaxima = 6f;
  
        float vert = cam.orthographicSize;  
        float horiz = vert * cam.aspect;  
  
        float centerX = cam.transform.position.x; // change if your center line is elsewhere  
  
        Vector2 pos = new Vector2(mousePos.x, mousePos.y);
        
        pos.x = Mathf.Clamp(mousePos.x, cam.transform.position.x - horiz, centerX);  
        pos.y = Mathf.Clamp(mousePos.y, cam.transform.position.y - vert, cam.transform.position.y + vert);  
        
        Vector2 novaPos = Vector2.MoveTowards(rb.position, pos, velMaxima * Time.fixedDeltaTime);
  
        rb.MovePosition(pos);
    }
}
