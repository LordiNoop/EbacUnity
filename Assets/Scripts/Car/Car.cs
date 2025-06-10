using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public GameObject carPrefab;

    public int speed = 20;
    public int gear = 5;

    public int TotalSpeed
    {
        get { return speed * gear; }
    }

    public void CreateCar()
    {
        var a = Instantiate(carPrefab);
        a.transform.position = Vector3.zero;
    }

#if UNITY_EDITOR
    [UnityEditor.MenuItem("Ebac/Car %t")]
    public static void CreateCar2()
    {
        Car scriptInstance = FindObjectOfType<Car>();

        if (scriptInstance != null && scriptInstance.carPrefab != null)
        {
            var a = Instantiate(scriptInstance.carPrefab);
            a.transform.position = Vector3.zero;
        }
    }
#endif
}
