using UnityEditorInternal;
using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 5f;
    [SerializeField] float currentSpeed = .1f;
    [SerializeField] float boostSpeed = 10f;
    [SerializeField] float regSpeed = 5f;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Boost"))
        {
            currentSpeed = boostSpeed;
            Destroy(collision.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        currentSpeed = regSpeed;
    }

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

        float moveAmount = currentSpeed * move * Time.deltaTime;
        float steerAmount = steer * steerSpeed * Time.deltaTime;
       
        transform.Rotate(0, 0, steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}
