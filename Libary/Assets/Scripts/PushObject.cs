using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PushObject : MonoBehaviour
{
    private Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public void Push(float strength)
    {
        Vector3 pushDirection = transform.position - Camera.main.transform.position;
        pushDirection.Normalize();

        rigidbody.AddForce(pushDirection * strength, ForceMode.Impulse);
    }
}
