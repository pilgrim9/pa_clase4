using System.Collections;
using UnityEngine;

public class Revolver : MonoBehaviour
{
    public float reloadTime = 1f;
    public float bullets;
    public float maxBullets = 6f;
    public bool reloading = false;

    void Start()
    {
        bullets = maxBullets;
    }

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
        if (Input.GetKeyDown(KeyCode.R) || bullets == 0 )
        {
            if (bullets < maxBullets && !reloading)
            {
                reloading = true;
                StartCoroutine(Reload());
            }
        }

    }
    IEnumerator Reload()
    {
        Debug.Log("Reloading");
        while (bullets < maxBullets && reloading)
        {
            yield return new WaitForSeconds(reloadTime);
            if (!reloading) break;
            bullets++;
            Debug.Log("Reloaded 1 bullet. Bullets: " + bullets);
        }
        reloading = false;
    }
    void Shoot()
    {
        if (bullets <= 0) return;
        bullets--;
        Debug.Log("Shoot");
        reloading = false;
    }
}
