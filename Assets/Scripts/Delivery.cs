using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour

{
    bool hasPackage;
    [SerializeField] float delay = 1f;



    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Package") && !hasPackage)
        {
            Debug.Log("picked up package");
            hasPackage = true;
            GetComponent<ParticleSystem>().Play();
            Destroy(collision.gameObject, delay);
        }



        if (collision.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("delivered package");
            hasPackage = false;
            GetComponent<ParticleSystem>().Stop();
        }

           

    }
      
}



