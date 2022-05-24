using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public struct RGProfilePhoto
{
    public Image outline;
    public Sprite sprite;
}

public class FotoSelector : MonoBehaviour
{
    //public List<Image> outlines;
    //public List<Sprite> fotosSprites;
    public List<RGProfilePhoto> profilePics;
    public Image fotoRG;

    private Image selectedBorder;
    private int selectedIndex;
    private bool selectedImgsChanged = false;

    public void ToggleSelection(int index)
    {
        if (selectedBorder != null)
            selectedBorder.enabled = !selectedBorder.enabled;

        selectedImgsChanged = true;
        selectedBorder = profilePics[index].outline;
        selectedBorder.enabled = !selectedBorder.enabled;

        selectedIndex = index;
    }

    public void CloseAndSelectPic()
    {
        fotoRG.enabled = true;
        fotoRG.sprite = profilePics[selectedIndex].sprite;
        fotoRG.SetNativeSize();
        //fotoRG.transform.localScale *= 3;
    }
}
