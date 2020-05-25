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
    // Start is called before the first frame update
    void Start()
    {
        
        // create file
        TextWriter data = new StreamWriter("position_sym1.csv");
    }

    // Update is called once per frame
    void Update()
    {
        string filepath = "position_sym1.csv";
        try
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filepath, true))
            {
                
                file.WriteLine("c" + "," + "b");
                file.Close();
            }
        }
        catch(Exception ex)
        {
            throw new ApplicationException("something wrong with csv file",ex);
        }
        
        //File.AppendAllText("position_sym1.csv", DateTime.Now.ToString());
    }
}
