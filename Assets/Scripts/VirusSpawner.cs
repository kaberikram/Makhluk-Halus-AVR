using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VirusSpawner : MonoBehaviour
{
    //[SerializeField] private GameObject _virusPrefab;

    public float cooldownTime = 5f;
    



    //private float nextfireTime = 0;

    public int maxAmmo = 5;
    public static int currentAmmo = -1;
    bool isCooldown = false;

    //public GameObject _virusPrefab;
    public Image abilityImage1;
    public GameObject ammo1, ammo2, ammo3, ammo4, ammo5; 



    private void Start()
    {
        
        if (currentAmmo == -1)
            currentAmmo = maxAmmo;
        abilityImage1.fillAmount = 1;
        ammo1.gameObject.SetActive(true);
        ammo2.gameObject.SetActive(true);
        ammo3.gameObject.SetActive(true);
        ammo4.gameObject.SetActive(true);
        ammo5.gameObject.SetActive(true);

    }

    void Update()
    {

         if (Input.GetMouseButtonDown(0))
         {
                Shoot();
                
         }
        

        if (isCooldown)
        {
           abilityImage1.fillAmount -= 1/cooldownTime * Time.deltaTime ;
            
            if(abilityImage1.fillAmount <= 0)
            {
                abilityImage1.fillAmount = 1;
                isCooldown = false;

            }


        }

        if (currentAmmo > maxAmmo)
            currentAmmo = 5;
        switch (currentAmmo)
        {
            case 5:
                ammo1.gameObject.SetActive(true);
                ammo2.gameObject.SetActive(true);
                ammo3.gameObject.SetActive(true);
                ammo4.gameObject.SetActive(true);
                ammo5.gameObject.SetActive(true);
                break;
            case 4:
                ammo1.gameObject.SetActive(true);
                ammo2.gameObject.SetActive(true);
                ammo3.gameObject.SetActive(true);
                ammo4.gameObject.SetActive(true);
                ammo5.gameObject.SetActive(false);
                break;
            case 3:
                ammo1.gameObject.SetActive(true);
                ammo2.gameObject.SetActive(true);
                ammo3.gameObject.SetActive(true);
                ammo4.gameObject.SetActive(false);
                ammo5.gameObject.SetActive(false);
                break;
            case 2:
                ammo1.gameObject.SetActive(true);
                ammo2.gameObject.SetActive(true);
                ammo3.gameObject.SetActive(false);
                ammo4.gameObject.SetActive(false);
                ammo5.gameObject.SetActive(false);
                break;
            case 1:
                ammo1.gameObject.SetActive(true);
                ammo2.gameObject.SetActive(false);
                ammo3.gameObject.SetActive(false);
                ammo4.gameObject.SetActive(false);
                ammo5.gameObject.SetActive(false);
                break;
            case 0:
                ammo1.gameObject.SetActive(false);
                ammo2.gameObject.SetActive(false);
                ammo3.gameObject.SetActive(false);
                ammo4.gameObject.SetActive(false);
                ammo5.gameObject.SetActive(false);
                break;

        }



    }

    void Shoot ()
    {
        

        Vector3 mouseScreenPosition = Input.mousePosition;
        Ray ray = Camera.main.ScreenPointToRay(mouseScreenPosition);
        RaycastHit hitInfo;

        int mask = 1 << LayerMask.NameToLayer("Ground");
        mask |= 1 << LayerMask.NameToLayer("PlayerBound");

        bool hit = Physics.Raycast(ray, out hitInfo, mask);

        if (hitInfo.collider.gameObject.layer == LayerMask.NameToLayer("Ground") && (currentAmmo > 0) && (isCooldown == false))
        {
            currentAmmo--;
            SpawnVirusAtposition(hitInfo.point);
            Debug.Log("hit");
            isCooldown = true;
            abilityImage1.fillAmount = 1;


        }
        else
        {
            Debug.Log("not hit");
        }

    }
       
   

    private void SpawnVirusAtposition(Vector3 spawnPosition)
    {
        //GameObject virus = Instantiate(_virusPrefab, spawnPosition, Quaternion.identity);
        GameObject b = Pool.singleton.Get("Virus");
        if (b != null)
        {
            b.transform.position = spawnPosition;
            b.transform.rotation = Quaternion.identity;
            b.SetActive(true);

        }
    }

   
}
