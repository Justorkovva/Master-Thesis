using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class WriteCSV : MonoBehaviour
{
   
    public string filename = "simulation_1.csv";
    public float wait_time = 0.01f;
    public float seconds = 10.0f;
    private float iterations;
    private TextWriter data;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        iterations = 1 / wait_time * seconds;
        data = new StreamWriter(filename);
        rb = GetComponent<Rigidbody>();
        StartCoroutine(Write_to_file());
    }

    IEnumerator Write_to_file()
    {
        for(int i = 0; i < iterations; i++)
        {
            yield return new WaitForSecondsRealtime(wait_time);
            Vector3 pos = GetComponent<Rigidbody>().position;
            data.WriteLine(pos[0] + ";" + pos[2]);
        }
        data.Close();
    }
}
