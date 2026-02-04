using UnityEngine;

public class Collectible : MonoBehaviour
{

    public float rotationSpeed;
    public GameObject onCollectEffect;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(0, 0, rotationSpeed);


    }


    private void OnTriggerEnter(Collider other) {

        // Destroy the Collictible
        Destroy(gameObject);

        // instatiate the particle effect
        Instantiate(onCollectEffect, transform.position, transform.rotation);
    }


}
