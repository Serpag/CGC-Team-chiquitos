using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public float speed = 10.0f;
    private Vector3 target;
    Vector3 moveDirection;

    void Start()
    {
        target = GameObject.FindWithTag("Player").transform.position;
        Destroy(gameObject, 5f);
        
        moveDirection = (target - transform.position);
        moveDirection.z = 0;       
        moveDirection.Normalize();
    }

    void Update()
    {
        float step = speed * Time.deltaTime;

        // move sprite towards the target location
        //transform.position = Vector2.MoveTowards(transform.position, target, step);
        transform.position = transform.position + moveDirection * speed* Time.deltaTime;
    }
}
