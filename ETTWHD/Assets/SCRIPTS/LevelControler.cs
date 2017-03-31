using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelControler : MonoBehaviour
{
    public int Level;
 
	public void zwiekszlevel()
   {
        Level++;
    }

    public void resetLevel()
    {
        Level = 1;

    }

}
