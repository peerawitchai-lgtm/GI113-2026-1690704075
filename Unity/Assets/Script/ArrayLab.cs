using System.Xml.Serialization;
using UnityEngine;

public class ArrayLab : MonoBehaviour
{
    string name = "hello";
    int score = 10;

    public string[] nameArray = { "Aom", "Ben", "Cat", "Dan", "Eve", "Fon" };
    public int[] scores = { 5, 7, 9, 1, 2, 6 };

    float[] wallet = { 10, 5, 0.25f, 0.50f, 1, 2, 100, 20, 50, 500, 1000 };
    void Start()
    {
        float forLoopTotal = 0;
        for (int i = 0; i < wallet.Length; i++)
        {
            forLoopTotal += wallet[i];
        }
        Debug.Log($"For Loop total money: {forLoopTotal}");

        float forEachTotal = 0;

        foreach (float money in wallet)
        {
            if (money == 0.50f)
            {
                continue;
            }
            forEachTotal += money;
        }
        void Update()
        {

        }
    }
}
