using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] num = {8,5,10,7};
        int[] num2 = {8,2,4,6};
        int[] num3 = {7,4,6,4};
        int[] result = new int[4];

        for(int i =0;i<4;i++){
            result = findLessThan(num,i);
            Debug.Log(result[i]);
        }
        
    }

    // El algoritmo empleado es de orden O(n^2), ya que para una entrada N se realizaran N al cuadrado iteraciones.
    int[] findLessThan(int[] num, int pos)
    {
        int[] result = {0,0,0,0};
        for(int i =0; i<4;i++){
            if(num[pos] > num[i])
            result[pos]++;
        }
        return result;
    }
}
