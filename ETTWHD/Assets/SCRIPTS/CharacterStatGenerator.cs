using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatGenerator : MonoBehaviour {

    public int STR;
    public int AGI;
    public int END;
    public int INT;
    public int CHA;

    public int MainStat;
    public int SecStat;

    void StatGenerator()
    {
        STR = Random.Range(1, 6);
        AGI = Random.Range(1, 6);
        END = Random.Range(1, 6);
        INT = Random.Range(1, 6);
        CHA = Random.Range(1, 6);

        MainStat = Random.Range(1, 6);
        switch (MainStat)
        {
            case 1:
                STR = STR + 5;
                print("MainStat STR");
                SecStat = Random.Range(1, 5);
                switch (SecStat)
                {
                    case 1:
                        AGI = AGI + 3;
                        print("SecStat AGI");
                        break;

                    case 2:
                        END = END + 3;
                        print("SecStat END");
                        break;

                    case 3:
                        INT = INT + 3;
                        print("SecStat INT");
                        break;

                    case 4:
                        CHA = CHA + 3;
                        print("SecStat CHA");
                        break;

                }
                break;

            case 2:
                AGI = AGI + 5;
                print("MainStat AGI");
                SecStat = Random.Range(1, 5);
                switch (SecStat)
                {
                    case 1:
                        STR = STR + 3;
                        print("SecStat STR");
                        break;

                    case 2:
                        END = END + 3;
                        print("SecStat END");
                        break;

                    case 3:
                        INT = INT + 3;
                        print("SecStat INT");
                        break;

                    case 4:
                        CHA = CHA + 3;
                        print("SecStat CHA");
                        break;

                }
                break;


            case 3:
                END = END + 5;
                print("MainStat END");
                SecStat = Random.Range(1, 5);
                switch (SecStat)
                {
                    case 1:
                        STR = STR + 3;
                        print("SecStat STR");
                        break;

                    case 2:
                        AGI = AGI + 3;
                        print("SecStat AGI");
                        break;

                    case 3:
                        INT = INT + 3;
                        print("SecStat INT");
                        break;

                    case 4:
                        CHA = CHA + 3;
                        print("SecStat CHA");
                        break;

                }
                break;

            case 4:
                INT = INT + 5;
                print("MainStat INT");
                SecStat = Random.Range(1, 5);
                switch (SecStat)
                {
                    case 1:
                        STR = STR + 3;
                        print("SecStat STR");
                        break;

                    case 2:
                        AGI = AGI + 3;
                        print("SecStat AGI");
                        break;

                    case 3:
                        END = END + 3;
                        print("SecStat END");
                        break;

                    case 4:
                        CHA = CHA + 3;
                        print("SecStat CHA");
                        break;

                }
                break;

            case 5:
                CHA = CHA +  5;
                print("MainStat CHA");
                SecStat = Random.Range(1, 5);
                switch (SecStat)
                {
                    case 1:
                        STR = STR + 3;
                        print("SecStat STR");
                        break;

                    case 2:
                        AGI = AGI + 3;
                        print("SecStat AGI");
                        break;

                    case 3:
                        END = END + 3;
                        print("SecStat END");
                        break;

                    case 4:
                        INT = INT + 3;
                        print("SecStat INT");
                        break;

                }
                break;
        }
    }

    private void Awake()
    {
        StatGenerator();
    }
}
