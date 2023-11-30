using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public string diamondTag = "diamond";

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag(diamondTag))
        {
            
            Destroy(collision.gameObject);
        }
    }
}
