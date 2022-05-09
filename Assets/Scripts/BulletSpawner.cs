using System.Collections;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    [SerializeField] private float reloadTime;
    [SerializeField] private float speed;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private Bullet bulletPrefab;

    private bool isLoaded = true;

    public void Update()
    {
        if (Input.GetKey(KeyCode.Space) && isLoaded)
        {
            StartCoroutine(Loading());
            CreateBullet();
        }
    }

    private void CreateBullet()
    {
        Bullet bullet = Instantiate(bulletPrefab, transform.position, transform.rotation).GetComponent<Bullet>();
        bullet.SetSpeed(speed, rotationSpeed);
        bullet.SetTarget(TargetManager.GetTarget());
    }

    private IEnumerator Loading()
    {
        isLoaded = false;

        while (!isLoaded)
        {
            yield return new WaitForSeconds(reloadTime);
            isLoaded = true;
        }
    }
}
