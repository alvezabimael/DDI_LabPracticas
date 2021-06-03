using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EjercicioPractica2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<string> list = new List<string>(20);
        list.Add("ABIMAEL ALVEZ MADRIGAL");
        list.Add("CRISTIAN ALFREDO ASTORGA SEPULVEDA");
        list.Add("ERICK ARTURO BECERRA PERAZA");
        list.Add("EDGAR ALBERTO CHAGALA JIMENEZ");
        list.Add("LUIS GERARDO DIAZ REYNOSO");
        list.Add("LUIS FERNANDO ESQUEDA GARCIA");
        list.Add("ISAAC HERNANDEZ CANO");
        list.Add("EDGAR MIGUEL LANDA LUNA");
        list.Add("LUIS ELOY LASCANO ORTIZ");
        list.Add("NEREO LOPEZ MORENO");
        list.Add("ARACELI LUEVANO CRUZ");
        list.Add("SERGIO ALONSO MARTINEZ SUAREZ");
        list.Add("JORGE ANTONIO MARTINEZ VILLANUEVA");
        list.Add("IVAN ALFREDO MORALES ROSALES");
        list.Add("FELIZ ABRAHAM QUINTERO CARRISOZA");
        list.Add("BRANDON RAYGOZA DE LA PAZ");
        list.Add("RAUL ARTURO RODRIGUEZ CONTRERAS");
        list.Add("MIGUEL ANGEL ROSAS OCAMPO");
        list.Add("DANIEL SANTOS MENDEZ");
        list.Add("JOSE LIAM TAPIA OLVERA");
        list.Sort();
        
        Debug.Log(findName(list,"SERGIO ALONSO MARTINEZ SUAREZ"));
        Debug.Log(findName(list,"GENESIS HERNANDEZ"));
       
    }

    // Algoritmo de busqueda binaria implementado en una lista de cadenas.
    // Ya que el algoritmo divide entre 2 el numero con cada iteracion podemos decir que esta operacion es de un logaritmo en base 2, por lo que es del tipo O(log(n)).
    static Boolean findName(List<String> lista, String name)
    {
        int left = 0, right = lista.Count - 1;  
        while (left <= right) {  
            int m = left + (right - left) / 2;  
  
            int res = name.CompareTo(lista[m]);  
            if (res == 0)  
                return true;  
            if (res > 0)  
                left = m + 1;    
            else
                right = m - 1;  
        }  
  
        return false;  
    } 
}
