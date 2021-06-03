using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioPractica3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] nums = {1,2,3,4,5};
        int[] result = findIndex(nums, 6);
        Debug.Log(result[0]);
        Debug.Log(result[1]);
    }

    // Update is called once per frame
    int[] findIndex(int[] nums, int target)
    {
        List<int> list = new List<int>();
        for(int i=0; i <= nums.Length; i++){
            for(int j = i+1; j <= nums.Length;j++){
                if(nums[i] + nums[j] == target){
                    list.Add(i);
                    list.Add(j);
                    return list.ToArray();
                }
            }
        }        

        return null;
        
    }
}
