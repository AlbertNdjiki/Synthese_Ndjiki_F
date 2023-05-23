using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireFlame : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform firePoint;
    public GameObject flamePrefab;

    // Update is called once per frame
    void Update()
    {
       if (Input.GetButtonDown("Fire1"))
        {
            shoot();
        }
    }

    void shoot ()

    {
        Instantiate(flamePrefab, firePoint.position, firePoint.rotation);
    }
}
