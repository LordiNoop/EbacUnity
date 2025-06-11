using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SkullUtil
{
#if UNITY_EDITOR
    [UnityEditor.MenuItem("Ebac/Test")]
    public static void Test()
    {
        Debug.Log("Test");
    }

    [UnityEditor.MenuItem("Ebac/Test2 %g")]
    public static void Test2()
    {
        Debug.Log("Test2");
    }
#endif

    public static void Scale(this Transform t, float size = 1.2f)
    {
        t.localScale = Vector3.one * size;
    }

    public static T GetRandom<T>(this List<T> list)
    {
        return list[Random.Range(0, list.Count)];
    }
}
