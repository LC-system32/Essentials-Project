using UnityEngine;

public class RotationCube : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float rotationSpeed;

    public GameObject onColliderEffects;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,rotationSpeed, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
        Destroy(gameObject);

        Instantiate(onColliderEffects,transform.position,transform.rotation);
        }
    }
}
