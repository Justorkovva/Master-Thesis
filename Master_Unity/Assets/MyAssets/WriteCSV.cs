using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class WriteCSV : MonoBehaviour
{
    public TextWriter data;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        // create file
        data = new StreamWriter("position_sym1.csv");
        rb = GetComponent<Rigidbody>();
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        for(int i = 0; i < 1000; i++)
        {
            yield return new WaitForSecondsRealtime(0.01f);
            Vector3 pos = GetComponent<Rigidbody>().position;
            data.WriteLine(pos[0]);
        }
        data.Close();
    }
}
