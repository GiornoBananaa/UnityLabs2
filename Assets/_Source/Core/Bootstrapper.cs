using Hotdogs;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private HotdogDataSO _classicHotdogData;
        [SerializeField] private HotdogDataSO _classicHotdogWithCucumberData;
        [SerializeField] private HotdogDataSO _classicHotdogWithOnionData;
        
        private void Awake()
        {
            Hotdog hotdogClassic = new HotdogClassic(
                _classicHotdogData.Name, _classicHotdogData.Weight);
            Hotdog hotdogWithCucumber = new HotdogWithCucumber(
                _classicHotdogWithCucumberData.Name, _classicHotdogWithCucumberData.Weight, hotdogClassic);
            Hotdog hotdogWithOnion = new HotdogWithOnion(
                _classicHotdogWithOnionData.Name, _classicHotdogWithOnionData.Weight, hotdogClassic);
            
            Debug.Log(hotdogClassic.GetName() + " - " + hotdogClassic.GetCost());
            Debug.Log(hotdogWithCucumber.GetName() + " - " + hotdogWithCucumber.GetCost());
            Debug.Log(hotdogWithOnion.GetName() + " - " + hotdogWithOnion.GetCost());
        }
    }
}
