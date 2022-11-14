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
    }
}
