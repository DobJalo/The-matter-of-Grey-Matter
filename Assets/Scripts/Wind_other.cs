using UnityEngine;

public class Wind_other : MonoBehaviour
{
    private float pushForce = 3f;
    public Vector3 windDirection = Vector3.right;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player")) // if player is in collider
        {
            Rigidbody playerRigidbody = other.GetComponent<Rigidbody>(); // get player rigidbody

            Vector3 pushVec = windDirection.normalized * pushForce; // create the push (like a wind)

            playerRigidbody.linearVelocity = new Vector3(pushVec.x, playerRigidbody.linearVelocity.y, pushVec.z); // move player in this direction

        }
    }
}
