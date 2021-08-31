using System.Collections;
using System.Linq;

using UnityEngine;
using UnityEngine.UI;

using ZhangM;

public class SubsidiaryPanel : MonoBehaviour
{
    public ISubsidiary gmData
    {
        get
        {
            return _gmData;
        }
        set
        {
            _gmData = value;
        }
    }

    public Text Name;
    public Text Businesses;

    private ISubsidiary _gmData;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gmData == null)
        {
            return;
        }

        Name.text = gmData.name;
        Businesses.text = $"{gmData.businesses.Count()}/{gmData.owner.maxBusinessCount}";
    }
}