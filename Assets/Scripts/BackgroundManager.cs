using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager : MonoBehaviour
{
    [SerializeField] private GameObject _marsBattlefield;
    [SerializeField] private GameObject _marsDunes;
    [SerializeField] private GameObject _hospitalRoom;
    [SerializeField] private GameObject _marsDomeOutpost;
    [SerializeField] private GameObject _hospitalOffice;
    [SerializeField] private GameObject _antennaDunes;


    // Start is called before the first frame update
    void Start()
    {
        _marsBattlefield.SetActive(true);
        _marsDunes.SetActive(false);
        _hospitalRoom.SetActive(false);
        _marsDomeOutpost.SetActive(false);
        _hospitalOffice.SetActive(false);
        _antennaDunes.SetActive(false);

    }

    public void ActivateMarsBattlefield()
    {
        _marsBattlefield.SetActive(true);
        _marsDunes.SetActive(false);
        _hospitalRoom.SetActive(false);
        _marsDomeOutpost.SetActive(false);
        _hospitalOffice.SetActive(false);
        _antennaDunes.SetActive(false);
    }

    public void ActivateMarsDunes()
    {
        _marsBattlefield.SetActive(false);
        _marsDunes.SetActive(true);
        _hospitalRoom.SetActive(false);
        _marsDomeOutpost.SetActive(false);
        _hospitalOffice.SetActive(false);
        _antennaDunes.SetActive(false);
    }

    public void ActivateHospitalRoom()
    {
        _marsBattlefield.SetActive(false);
        _marsDunes.SetActive(false);
        _hospitalRoom.SetActive(true);
        _marsDomeOutpost.SetActive(false);
        _hospitalOffice.SetActive(false);
        _antennaDunes.SetActive(false);
    }
    public void ActivateMarsDomeOutpost()
    {
        _marsBattlefield.SetActive(false);
        _marsDunes.SetActive(false);
        _hospitalRoom.SetActive(false);
        _marsDomeOutpost.SetActive(true);
        _hospitalOffice.SetActive(false);
        _antennaDunes.SetActive(false);
    }
    public void ActivateHospitalOffice()
    {
        _marsBattlefield.SetActive(false);
        _marsDunes.SetActive(false);
        _hospitalRoom.SetActive(false);
        _marsDomeOutpost.SetActive(false);
        _hospitalOffice.SetActive(true);
        _antennaDunes.SetActive(false);
    }
    public void ActivateAntennaDunes()
    {
        _marsBattlefield.SetActive(false);
        _marsDunes.SetActive(false);
        _hospitalRoom.SetActive(false);
        _marsDomeOutpost.SetActive(false);
        _hospitalOffice.SetActive(false);
        _antennaDunes.SetActive(true);
    }
}
