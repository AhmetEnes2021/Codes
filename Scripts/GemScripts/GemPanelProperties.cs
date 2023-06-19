using UnityEngine;
using TMPro;

[System.Serializable]
public class GemPanelProperties : MonoBehaviour//Toplanan gemlerin gösterildiği paneldeki objelerin tutulduğu liste
{
    public GameObject GemIcon;
    public TMP_Text GemNameText;
    public TMP_Text CollectedGemCountText;
}
