using UnityEngine;

public class BallCatcher : MonoBehaviour
{
    public GameObject Spawnpoint;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.transform.position = Spawnpoint.transform.position;
            other.attachedRigidbody.angularVelocity = Vector3.zero;
            other.attachedRigidbody.linearVelocity = Vector3.zero;
        }
    }
}
