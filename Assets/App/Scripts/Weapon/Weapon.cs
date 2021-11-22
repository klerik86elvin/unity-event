using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] float rateOfFire = 0.5f;
    [SerializeField] GameObject muzzleFireEffect;

    [SerializeField] float demage = 10f;
    // Start is called before the first frame update
    void Start()
    {
        muzzleFireEffect.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            muzzleFireEffect.SetActive(true);
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit))
            {
                if(hit.collider.gameObject.layer == LayerMask.NameToLayer("Enemy"))
                {
                    GameObject enemy = hit.collider.gameObject;
                    enemy.GetComponent<Enemy>().TakeDemage(demage);

                }
            }
        }
        if (Input.GetButtonUp("Fire1"))
        {
            muzzleFireEffect.SetActive(false);
        }
    }

   /* void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPosition.position, bulletSpawnPosition.rotation);
    }*/

   
}
