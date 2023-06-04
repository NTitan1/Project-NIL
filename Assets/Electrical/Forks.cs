using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Forks : MonoBehaviour
{
    int[,] PrimMatrix = new int[9, 13];

   public int i = 0;
   public int j = 0;

    public void Fork(int i, int j, char dir)
    {
        switch (PrimMatrix[i,j])
        {
            case 1:
                if (dir == 'b')
                {
                    Fork(i + 1, j, 'l');
                    break;
                }
                else if (dir == 'r')
                {
                    Fork(i, j + 1, 'r');
                    break;
                }
                else
                    return;
            case 2:
                if (dir == 'a')
                {
                    Fork(i + 1, j, 'l');
                    break;
                }
                else if (dir == 'r')
                {
                    Fork(i, j - 1, 'b');
                    break;
                }
                else
                    return;
            case 3:
                if (dir == 'l')
                {
                    Fork(i, j - 1, 'b');
                    break;
                }
                else if (dir == 'a')
                {
                    Fork(i - 1, j, 'r');
                    break;
                }
                else
                    return;
            case 4:
                if (dir == 'l')
                {
                    Fork(i, j + 1, 'a');
                    break;
                }
                else if (dir == 'b')
                {
                    Fork(i - 1, j, 'r');
                    break;
                }
                else
                    return;
            case 5:
                if (dir == 'a')
                {
                    Fork(i, j + 1, 'a');
                    break;
                }
                else if (dir == 'b')
                {
                    Fork(i, j - 1, 'b');
                    break;
                }
                else
                    return;
            case 6:
                if (dir == 'l')
                {
                    Fork(i + 1, j, 'l');
                    break;
                }
                else if (dir == 'r')
                {
                    Fork(i - 1, j, 'r');
                    break;
                }
                else
                    return;
            case 7:
                if (dir == 'l')
                {
                    Fork(i, j + 1, 'a');
                    Fork(i + 1, j, 'l');
                    break;
                }
                else if (dir == 'b')
                {
                    Fork(i - 1, j, 'r');
                    Fork(i + 1, j, 'l');
                    break;
                }
                else if (dir == 'r')
                {
                    Fork(i - 1, j, 'r');
                    Fork(i, j + 1, 'a');
                    break;
                }
                else return;
            case 8:
                if (dir == 'b')
                {
                    Fork(i + 1, j, 'l');
                    Fork(i, j - 1, 'b');
                    break;
                }
                else if (dir == 'r')
                {
                    Fork(i, j + 1, 'a');
                    Fork(i, j - 1, 'b');
                    break;
                }
                else if (dir == 'a')
                {
                    Fork(i, j + 1, 'a');
                    Fork(i + 1, j, 'l');
                    break;
                }
                else
                    return;
            case 9:
                if (dir == 'l')
                {
                    Fork(i + 1, j, 'l');
                    Fork(i, j - 1, 'b');
                    break;
                }
                else if (dir == 'r')
                {
                    Fork(i - 1, j, 'r');
                    Fork(i, j - 1, 'b');
                    break;
                }
                else if (dir == 'a')
                {
                    Fork(i - 1, j, 'r');
                    Fork(i + 1, j, 'l');
                    break;
                }
                else
                    return;
            case 10:
                if (dir == 'l')
                {
                    Fork(i, j + 1, 'a');
                    Fork(i, j - 1, 'b');
                    break;
                }
                else if (dir == 'b')
                {
                    Fork(i - 1, j, 'r');
                    Fork(i, j - 1, 'b');
                    break;
                }
                else if (dir == 'a')
                {
                    Fork(i - 1, j, 'r');
                    Fork(i, j + 1, 'a');
                    break;
                }
                else
                    return;
            case 11:
                if (dir == 'l')
                {
                    Fork(i, j + 1, 'a');
                    Fork(i + 1, j, 'l');
                    Fork(i, j - 1, 'b');
                    break;
                }
                else if (dir == 'b')
                {
                    Fork(i - 1, j, 'r');
                    Fork(i + 1, j, 'l');
                    Fork(i, j - 1, 'b');
                    break;
                }
                else if (dir == 'r')
                {
                    Fork(i, j + 1, 'a');
                    Fork(i - 1, j, 'r');
                    Fork(i, j - 1, 'b');
                    break;
                }
                else
                    return;

            default:
                break;
               
            
        }
        return;
    }
        // Start is called before the first frame update
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    }
