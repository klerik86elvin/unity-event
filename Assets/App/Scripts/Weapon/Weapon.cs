using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DynamicBox.EventManagement;

public class Weapon : MonoBehaviour
{
    public WeaponSO data;
    [SerializeField] GameObject muzzleFireEffect;
    //[SerializeField] Sprite muzzle;
    // Start is called before the first frame update

    void OnEnable()
    {
        EventManager.Instance.AddListener<WeaponBuyEvent>(UpdateWeaponHandle);
    }

    void OnDisable()
    {
        EventManager.Instance.RemoveListener<WeaponBuyEvent>(UpdateWeaponHandle);
    }
    void Start()
    {
        muzzleFireEffect.SetActive(false);
        data = transform.parent.GetComponent<Player>().Weapon;
    }

    // Update is called once per frame
    void Update()
    {
        shoot();
    }
    private void shoot()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            muzzleFireEffect.SetActive(true);
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit))
            {
                if (hit.collider.gameObject.layer == LayerMask.NameToLayer("Enemy"))
                {
                    GameObject enemy = hit.collider.gameObject;
                    enemy.GetComponent<Enemy>().TakeDemage(data.Demage);
                }
            }
        }
        if (Input.GetButtonUp("Fire1"))
        {
            muzzleFireEffect.SetActive(false);
        }
    }
    private void UpdateWeaponHandle(WeaponBuyEvent eventDetails)
    {
        data = eventDetails.Weapon;
    }
}
