using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;



    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Package"))
        {
             Debug.Log("picked up package");
        }



        if (collision.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("delivered package");
            hasPackage = false;
        }

           

    }
      
}



