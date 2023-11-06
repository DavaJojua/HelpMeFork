using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CodeLetterPanel : MonoBehaviour
{
    public GameObject player;
    public GameObject TPPoint;
    [SerializeField]
    private string num1;
    [SerializeField]
    private string num2;
    [SerializeField]
    private string num3;
    [SerializeField]
    private string num4;
    [SerializeField]
    private string num5;
    [SerializeField]
    private string num6;
    [SerializeField]
    private string num7;
    [SerializeField]
    private string num8;
    [SerializeField]
    private string num9;

    public List<string> code = new List<string>();


    public void One()
    {
        if (code.Count < 9)
        {
            code.Add(1.ToString()) ;
        }
    }
    public void Two()
    {
        if (code.Count < 9)
        {
            code.Add(2.ToString());
        }
    }
    public void Three()
    {
        if (code.Count < 9)
        {
            code.Add(3.ToString());
        }
    }
    public void Four()
    {
        if (code.Count < 9)
        {
            code.Add(4.ToString());
        }
    }
    public void Five()
    {
        if (code.Count < 9)
        {
            code.Add(5.ToString());
        }
    }
    public void Six()
    {
        if (code.Count < 9)
        {
            code.Add(6.ToString());
        }
    }
    public void Seven()
    {
        if (code.Count < 9)
        {
            code.Add(7.ToString());
        }
    }
    public void Eight()
    {
        if (code.Count < 9)
        {
            code.Add(8.ToString());
        }
    }
    public void Nine()
    {
        if (code.Count < 9)
        {
            code.Add(9.ToString());
        }
    }
    public void Zero()
    {
        if (code.Count < 9)
        {
            code.Add(0.ToString());
        }
    }
    public void A()
    {
        if (code.Count < 9)
        {
            code.Add("a");
        }
    }
    public void B()
    {
        if (code.Count < 9)
        {
            code.Add("b");
        }
    }
    public void C()
    {
        if (code.Count < 9)
        {
            code.Add("c");
        }
    }
    public void D()
    {
        if (code.Count < 9)
        {
            code.Add("d");
        }
    }
    public void E()
    {
        if (code.Count < 9)
        {
            code.Add("e");
        }
    }
    public void F()
    {
        if (code.Count < 9)
        {
            code.Add("f");
        }
    }
    public void G()
    {
        if (code.Count < 9)
        {
            code.Add("g");
        }
    }
    public void H()
    {
        if (code.Count < 9)
        {
            code.Add("h");
        }
    }
    public void I()
    {
        if (code.Count < 9)
        {
            code.Add("i");
        }
    }
    public void OK()
    {
        if (code.Count == 9)
        {
            if (code[0] == num1)
            {
                if (code[1] == num2)
                {
                    if (code[2] == num3)
                    {
                        if (code[3] == num4)
                        {
                            if (code[4] == num5)
                            {
                                if (code[5] == num6)
                                {
                                    if (code[6] == num7)
                                    {
                                        if (code[7] == num8)
                                        {
                                            if (code[8] == num9)
                                            {
                                                Debug.Log("Penis");
                                                player.transform.position = TPPoint.transform.position;
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
}

