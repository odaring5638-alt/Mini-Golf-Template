using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision Other)
    {
        if (Other.gameObject.CompareTag("Ball"))
        {
            Rigidbody rigidBody = Other.gameObject.GetComponent<Rigidbody>();
            rigidBody.linearVelocity = velicity 200
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
