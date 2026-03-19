using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5f;   // mỗi variant sẽ override
    public int health = 100;   // optional

    void Update()
    {
        Move();
    }

    void Move()
    {
        // di chuyển về phía trước (trục Z)
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}