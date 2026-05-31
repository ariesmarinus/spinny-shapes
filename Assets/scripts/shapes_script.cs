using System.Collections.Generic;
using UnityEngine;

public class shapes_script : MonoBehaviour
{
    public GameObject[] shapes;
    private List<GameObject> new_shapes;
    private List<Vector3> axises;
    private List<Vector3> random_axises;
    private List<int> random_angles;
    private List<float> random_speeds;
    private List<float> random_lenght;
    private List<float> random_width;
    private List<float> random_thickness;
    private List<float> random_scale;
    private List<float> red_t;
    private List<float> green_t;
    private List<float> blue_t;
    private List<float> red_b;
    private List<float> green_b;
    private List<float> blue_b;
    void Start()
    {
        // shapes
        new_shapes = new List<GameObject>();

        // random rotation
        axises = new List<Vector3> { Vector3.up, Vector3.forward, Vector3.left, -Vector3.up, -Vector3.forward, -Vector3.left };
        random_axises = new List<Vector3>();
        random_angles = new List<int>();
        random_speeds = new List<float>();

        // random size
        random_lenght = new List<float>();
        random_width = new List<float>();
        random_thickness = new List<float>();
        random_scale = new List<float>();

        // random colour
        red_t = new List<float>();
        green_t = new List<float>();
        blue_t = new List<float>();
        red_b = new List<float>();
        green_b = new List<float>();
        blue_b = new List<float>();

        for (var i = 0; i < 25; i++)
        {
            GenerateEverything();
            
        }

        SetColoursAndSize();
    }

    void Update()
    {
        RotateShapes();
    }

    void GenerateEverything()
    {
        for (var e = 0; e < shapes.Length; e++)
        {
            new_shapes.Add(Instantiate(shapes[e], new Vector3(Random.Range(-20, 300), Random.Range(-20, 35), Random.Range(-20, 300)), Quaternion.identity)); 
            AddRandomNumbers();
        }
    }
    void AddRandomNumbers()
    {
        random_axises.Add(axises[Random.Range(0, 5)]);
        random_angles.Add(Random.Range(1, 100));
        random_speeds.Add(Random.Range(0.1f, 1f) * Time.deltaTime);
        
        red_t.Add(Random.Range(0f, 1f));
        green_t.Add(Random.Range(0f, 1f));
        blue_t.Add(Random.Range(0f, 1f));
        red_b.Add(Random.Range(0f, 1f));
        green_b.Add(Random.Range(0f, 1f));
        blue_b.Add(Random.Range(0f, 1f));

        random_lenght.Add(Random.Range(1f, 10f));
        random_width.Add(Random.Range(1f, 10f));
        random_thickness.Add(Random.Range(1f, 10f));
        random_scale.Add(Random.Range(0.1f, 6f));
    }

    void SetColoursAndSize()
    {
        for (var i = 0; i < new_shapes.Count; i++)
        {
            new_shapes[i].GetComponent<MeshRenderer>().material.SetColor("_colour_t", new Color(red_t[i], green_t[i], blue_t[i]));
            new_shapes[i].GetComponent<MeshRenderer>().material.SetColor("_colour_b", new Color(red_b[i], green_b[i], blue_b[i]));

            new_shapes[i].transform.localScale = new Vector3(random_lenght[i], random_width[i], random_thickness[i]);
            new_shapes[i].transform.localScale *= random_scale[i];
        }
    }

    void RotateShapes()
    {
        for (var i = 0; i < new_shapes.Count; i++)
        {
            new_shapes[i].transform.Rotate(random_axises[i], random_angles[i] * random_speeds[i]);
        }
    }
}

//   TO DO:
// Add more types of shapes
// Make it so nothing appears on land but right next to it