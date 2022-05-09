using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private float speed;

    private void Start()
    {
        TargetManager.SetTarget(this);
    }

    private void FixedUpdate()
    {
        transform.RotateAround(new Vector3(0, 0, 0), Vector3.up, speed * Time.fixedDeltaTime);
    }
}
