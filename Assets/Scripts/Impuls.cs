using UnityEngine;

public class Impuls : MonoBehaviour
{
    private Rigidbody m_rigidbody;
    private float thrust;

    private void Start()
    {   
        m_rigidbody = GetComponent<Rigidbody>();
        thrust = 5f;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.tag.Equals("redCube") && collision.gameObject.tag.Equals("blueWall"))
        {
            m_rigidbody.AddForce(thrust, 0f, 0f, ForceMode.Impulse);
        }
        if (gameObject.tag.Equals("blueCube") && collision.gameObject.tag.Equals("redWall"))
        {
            m_rigidbody.AddForce(-thrust, 0f, 0f, ForceMode.Impulse);
        }
    }
}
