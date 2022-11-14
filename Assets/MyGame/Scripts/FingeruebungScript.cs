using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingeruebungScript : MonoBehaviour
{
    //Deklaration eines Arrays namens array vom Datentyp int
    int[] array;
    //Deklaration von array1, array2, array3. array4 und deren Initialiserung auf 3 unterschiedliche Arten:
    int[] array1 = new int[4];
    int[] array2 = new int[4] { 21, 22, 23, 24 };
    int[] array3 = new int[] { 31, 32, 33,34,35,36,37};
    string[] array4 = new string[10];
    public GameObject[] arrayColoredImagesRed;
    private void Start()
    {
        for (int i = 0; i < array4.Length; i++)
        {
            array4[i] = "array4";
        }

        arrayColoredImagesRed = GameObject.FindGameObjectsWithTag("RedImage");

        AusgabeErstes();
        AusgabeLetztes();
    }

    // 1) auf erstes Element -- Jeweils ein Debug.Log ausgeben. Beim arrayColoredImageRed den Namen des Objektes ausgeben.
    private void AusgabeErstes()
    {
        Debug.Log("array1 erste Zahl: " + array1[0]);
        Debug.Log("array2 erste Zahl: " + array2[0]);
        Debug.Log("array3 erste Zahl: " + array3[0]);
        Debug.Log("array4 erster String: " + array4[0]);
        Debug.Log("arrayColoredImagesRed erstes Object: " + arrayColoredImagesRed[0].name);
    }
    private void AusgabeLetztes()
    {
        Debug.Log("array1 letzte Zahl: " + array1[array1.Length-1]);
        Debug.Log("array2 letzte Zahl: " + array2[array2.Length - 1]);
        Debug.Log("array3 letzte Zahl: " + array3[array3.Length - 1]);
        Debug.Log("array4 letzter String: " + array4[array4.Length - 1]);
        Debug.Log("arrayColoredImagesRed letztes Object: " + arrayColoredImagesRed[arrayColoredImagesRed.Length-1].name);
    }
}
