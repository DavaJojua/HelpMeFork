using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CodePanel : MonoBehaviour
{
    public GameObject player;
    [SerializeField]
    private int num1;
    [SerializeField]
    private int num2;
    [SerializeField]
    private int num3;
    [SerializeField]
    private int num4;

    private List<int> code = new List<int>();


    public void One()
    {
        if (code.Count < 4)
        {
            code.Add(1);
        }
    }
    public void Two()
    {
        if (code.Count < 4)
        {
            code.Add(2);
        }
    }
    public void Three()
    {
        if (code.Count < 4)
        {
            code.Add(3);
        }
    }
    public void Four()
    {
        if (code.Count < 4)
        {
            code.Add(4);
        }
    }
    public void Five()
    {
        if (code.Count < 4)
        {
            code.Add(5);
        }
    }
    public void Six()
    {
        if (code.Count < 4)
        {
            code.Add(6);
        }
    }
    public void Seven()
    {
        if (code.Count < 4)
        {
            code.Add(7);
        }
    }
    public void Eight()
    {
        if (code.Count < 4)
        {
            code.Add(8);
        }
    }
    public void Nine()
    {
        if (code.Count < 4)
        {
            code.Add(9);
        }
    }
    public void Zero()
    {
        if (code.Count < 4)
        {
            code.Add(0);
        }
    }
    public void OK()
    {
        if (code.Count == 4)
        {
            if(code[0] == num1)
            {
                if (code[1] == num2)
                {
                    if (code[2] == num3)
                    {
                        if (code[3] == num4)
                        {
                            player.transform.position = new Vector3(54.3f, 1.52f, 5.98f);
                                Debug.Log("ja");
                        }
                        else
                        {
                            code.Clear();
                        }
                    }
                    else
                    {
                        code.Clear();
                    }
                }
                else
                {
                    code.Clear();
                }
            }
            else
            {
                code.Clear();
            }
        }
        else
        {
            code.Clear();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

}

