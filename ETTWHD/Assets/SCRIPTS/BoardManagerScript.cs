using UnityEngine;
using System;
using System.Collections.Generic; //allows us to use lists.
using Random = UnityEngine.Random; //Tells Random to use unity engine random nuber generator.

namespace Completed
{

    public class BoardManagerScript : MonoBehaviour
    {
        //Using Serializable allows us to embed a class with sub properties in the inspector.
        [Serializable]
        public class Count
        {
            public int minimum; //minimum value for our Count class.
            public int maximum; //maximum value for our Count class.

            //Assignment constructor
            public Count (int min, int max)
            {
                minimum = min;
                maximum = max;

            }
        }

        public int columns = 25;
        public int rows = 25;
        public GameObject Exit; //Prefab to spawn for exit
        public GameObject[] floorTiles; //Array of floor prefabs
        

        private Transform boardHolder; // A variable to store refrence to the transform of our board object.
        private List<Vector3> gridPositions = new List<Vector3>(); //A list of possible locations to place tiles.


        //Clears our list gridPositions and prepares it to generate a new board.
        void InitialiseList()
        {

            //Clear our list gridPositions.
            gridPositions.Clear();

            //Loop through x axis (columns).
            for(int x = 1; x < columns-1; x++)
            {
                //Within each column loop throug z axis (rows).
                for(int z = 1; z < rows-1; z++)
                {
                    //At each index add a new Vector3 to our list with the x and y coordinates of that position.
                    gridPositions.Add(new Vector3(x, 0f, z));
                }
            }
        }

        //sets up floor of the game board.
        void BoardSetup()
        {
            //instantiate Board and set boardHolder to its transform.
            boardHolder = new GameObject("Board").transform;

            //loop along x axis to place wall
            for(int x =-1; x < columns + 1; x++)
            {
                //loop along z axis
                for(int z= -1; z < rows + 1; z++)
                {
                    //choose a random floor from prefab array and prepare to instantiate it.
                    GameObject toInstantiate = floorTiles[Random.Range(0, floorTiles.Length)];

                    //instantiate the GameObject instance usng the prefab chosen for toInstantiate at the Vector3 corresponding to current grid positon in loop, cast it to GameObject.
                    GameObject instance = Instantiate(toInstantiate, new Vector3(x, 0f, z), Quaternion.identity) as GameObject;

                    //Set the parent of our newly instantiated object instance to boardHolder.
                    instance.transform.SetParent(boardHolder);
                }
            }
        }

        //SetupScene initializes our level and calls the previous functions to lay out the game board 
        public void SetupScene (int level)
        {
            //Creates floor.
            BoardSetup();

            //Reset our list of gridpositions.
            InitialiseList();

        }
    }
}