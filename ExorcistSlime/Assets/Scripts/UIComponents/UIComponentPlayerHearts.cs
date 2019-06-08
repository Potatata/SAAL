using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UIComponents
{
    public class UIComponentPlayerHearts : UIComponent
    {

        public Image[] playerHeartsArray;
        public Sprite fullHeart;
        public Sprite emptyHeart;

        public override void Start()
        {
            for (int i = 0; i < playerHeartsArray.Length; i++)
            {
                playerHeartsArray[i].enabled = true;
            }
        }

        public override void UpdateUI(Health health)
        { 
        }

        public void UpdateUIPlayer(int health)
        {
            for (int i = 0; i < playerHeartsArray.Length; i++)
            {
                if(i < health)
                {
                    playerHeartsArray[i].sprite = fullHeart;
                }
                else
                {
                    playerHeartsArray[i].sprite = emptyHeart;
                }
            }
        }
    }
}
