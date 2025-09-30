using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class WASD : MonoBehaviour
{
    //variables

    public Rigidbody2D rb;

    public float speed;

    private Vector2 _direction;

    public InputActionReference action;



   

    // Update is called once per frame
    void Update()
    {
        _direction = action.action.ReadValue<Vector2>();  
    }


    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(x: _direction.x * speed, y: _direction.y * speed);
    }

}
