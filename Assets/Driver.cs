using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = .5f;
    [SerializeField] float moveSpeed = .1f;
    
     void Update()
    {
        float move = 0f;
        float steer = 0f;
        if (Keyboard.current.wKey.isPressed)
        {
            move = 1f;
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            move = -1f;
        }
      
      if (Keyboard.current.aKey.isPressed)
        {
            steer = 1f;
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            steer = -1f;
        }
        
       
       
        transform.Rotate(0, 0, steer * steerSpeed);
        transform.Translate(0, moveSpeed * move, 0);
    }
}
