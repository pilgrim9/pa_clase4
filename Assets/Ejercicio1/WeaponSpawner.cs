using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WeaponSpawner : MonoBehaviour
{
    [SerializeField] InputField inputField;
    [SerializeField] GameObject defaultWeapon;
    public void Spawn()
    {
        Object weaponResource = Resources.Load("Armas/" + inputField.text);
        weaponResource ??= defaultWeapon;
        GameObject weapon = Instantiate(weaponResource) as GameObject;
        weapon.transform.position = transform.position;
    }
}
