using UnityEngine;
using UnityEngine.UI;

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
        WertMitIndex();
        WertAlsString();
        EinzelneElemente();
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

    // 2) auf letzes Element -- Jeweils ein Debug.Log ausgeben. Beim arrayColoredImageRed den Namen des Objektes ausgeben.
    private void AusgabeLetztes()
    {
        Debug.Log("array1 letzte Zahl: " + array1[array1.Length-1]);
        Debug.Log("array2 letzte Zahl: " + array2[array2.Length - 1]);
        Debug.Log("array3 letzte Zahl: " + array3[array3.Length - 1]);
        Debug.Log("array4 letzter String: " + array4[array4.Length - 1]);
        Debug.Log("arrayColoredImagesRed letztes Object: " + arrayColoredImagesRed[arrayColoredImagesRed.Length-1].name);
    }

    //1) Eine Methode schreiben die die Werte mit zugehörigen index als Debug.Log ausgibt.
    private void WertMitIndex()
    {
        for(int i = 0; i < array3.Length; i++)
        {
            Debug.Log("Wert von array3 an Index " + i + " = " + array3 [i].ToString());
        }
    }

    //2) Eine Methode schreiben die die Werte des Arrays als einen langen string ausgibt, z.b. 1 2 3 4
    private void WertAlsString()
    {
        string allValues = "";

        for(int i = 0; i < array3.Length; i++)
        {
            allValues = allValues + " " + array3[i].ToString();
        }

        Debug.Log(allValues);
    }

    private void EinzelneElemente()
    {
        //Greifen Sie auf das 4te Elemente in array1 zu und ändern sie den Wert auf 3. Geben Sie das Element mittels Debug.Log aus
        array1[3] = 3;
        Debug.Log(array1[3]);
        //Greifen Sie auf das 3te Element in array2 zu und ändern sie den Wert auf 203. Geben Sie das Element mittels Debug.Log au
        array2[2] = 203;
        Debug.Log(array2[2]);
        //Greifen Sie auf das 6te Element in array3 zu und ändern sie die Farbe auf 333.
        array3[5] = 333;
        Debug.Log(array3[5]);
        //Greifen Sie auf das 3te Element in array4 zu und ändern sie den Wert auf "heute". Geben Sie das Element mittels Debug.Log aus
        array4[2] = "heute";
        Debug.Log(array4[2]);
        //Greifen Sie auf das 3te Element in arrayColoredImagesRed zu und ändern sie die Farbe auf grün. Die Änderung sollte in der Scene/Game View ersichtlich sein
        arrayColoredImagesRed[2].GetComponent<Image>().color = Color.green;
    }
}
