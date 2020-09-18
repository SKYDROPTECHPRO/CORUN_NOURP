using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPower : MonoBehaviour
{
    public float movespeed_hor { get; private set; }
    [SerializeField] private List<S_PlayerModel> playermodels;
    private List<GameObject> modelprefabs;
    private int currentplayer=-1;
    // Start is called before the first frame update
    void Awake()
    {
        modelprefabs=new List<GameObject>();
        foreach (S_PlayerModel model in playermodels)
        {
            GameObject tempmodel = Instantiate(model.playermodel,transform);
            tempmodel.SetActive(false);
            modelprefabs.Add(tempmodel);
        }
    }

    public void changeplayer(int modelnumber)
    {
        if (modelnumber != currentplayer && modelnumber<modelprefabs.Count)
        {
            if (currentplayer != -1) { modelprefabs[currentplayer].SetActive(false); }
            currentplayer = modelnumber;
            modelprefabs[currentplayer].SetActive(true);
            gameObject.name = playermodels[currentplayer].modelname;
            movespeed_hor = playermodels[currentplayer].movespeed_horizontal;
        }
    }
}
