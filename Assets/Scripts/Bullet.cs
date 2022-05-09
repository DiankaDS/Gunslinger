using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float speed;
    private float speedAngle;
    private Target target;

    public void SetSpeed(float flySpeed, float rotationSpeed)
    {
        speed = flySpeed;
        speedAngle = rotationSpeed;
    }

    public void SetTarget(Target targetToSet)
    {
        target = targetToSet;
    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.RotateTowards(
            transform.rotation, 
            Quaternion.LookRotation(target.transform.position - transform.position), 
            speedAngle * Time.fixedDeltaTime
        );
        transform.position += transform.forward * speed * Time.fixedDeltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == target.gameObject) Destroy(gameObject);
    }
}
