using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    public bool isInteractable = true;
    void OnTriggerEnter(Collider other)
    {
        // Check if the object is interactable and the collider belongs to the player
        if (isInteractable && other.CompareTag("Player"))
        {
            Interact();
        }
    }

    void Interact()
    {
        // Implement interaction logic here
        Debug.Log("Interacting with " + gameObject.name);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
