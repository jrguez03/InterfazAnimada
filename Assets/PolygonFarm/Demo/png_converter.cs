using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
//
using UnityEngine.Networking;

public class png_converter : MonoBehaviour
{
    Texture2D icon;
    public byte[] bytes;
    

    // Start is called before the first frame update
    void Start()
    {
    
        /* Create .png images of Prefabs in Scene and save the .png files in Assets/images folder */
    
    
        icon = AssetPreview.GetAssetPreview(GameObject.Find("Axe1H_Basic")); 
        bytes = ImageConversion.EncodeToPNG(icon);
        File.WriteAllBytes(Application.dataPath + "/images/axe_1.png", bytes);
       
        icon = AssetPreview.GetAssetPreview(GameObject.Find("Axe1H_Medium")); 
        bytes = ImageConversion.EncodeToPNG(icon);
        File.WriteAllBytes(Application.dataPath + "/images/axe_2.png", bytes);
        
        icon = AssetPreview.GetAssetPreview(GameObject.Find("Axe1H_Epic")); 
        bytes = ImageConversion.EncodeToPNG(icon);
        File.WriteAllBytes(Application.dataPath + "/images/axe_3.png", bytes);
        
        icon = AssetPreview.GetAssetPreview(GameObject.Find("Axe2H_Basic")); 
        bytes = ImageConversion.EncodeToPNG(icon);
        File.WriteAllBytes(Application.dataPath + "/images/axe_4.png", bytes);
        
        icon = AssetPreview.GetAssetPreview(GameObject.Find("Axe2H_Medium")); 
        bytes = ImageConversion.EncodeToPNG(icon);
        File.WriteAllBytes(Application.dataPath + "/images/axe_5.png", bytes);
       
        icon = AssetPreview.GetAssetPreview(GameObject.Find("Axe2H_Epic")); 
        bytes = ImageConversion.EncodeToPNG(icon);
        File.WriteAllBytes(Application.dataPath + "/images/axe_6.png", bytes);
        
        icon = AssetPreview.GetAssetPreview(GameObject.Find("Wand_Basic")); 
        bytes = ImageConversion.EncodeToPNG(icon);
        File.WriteAllBytes(Application.dataPath + "/images/wand_1.png", bytes);
        
        icon = AssetPreview.GetAssetPreview(GameObject.Find("Wand_Medium")); 
        bytes = ImageConversion.EncodeToPNG(icon);
        File.WriteAllBytes(Application.dataPath + "/images/wand_2.png", bytes);
        
        icon = AssetPreview.GetAssetPreview(GameObject.Find("Wand_Epic")); 
        bytes = ImageConversion.EncodeToPNG(icon);
        File.WriteAllBytes(Application.dataPath + "/images/wand_3.png", bytes);
        
        icon = AssetPreview.GetAssetPreview(GameObject.Find("Mace1H_Basic")); 
        bytes = ImageConversion.EncodeToPNG(icon);
        File.WriteAllBytes(Application.dataPath + "/images/mace_1.png", bytes);
        
        icon = AssetPreview.GetAssetPreview(GameObject.Find("Mace1H_Medium")); 
        bytes = ImageConversion.EncodeToPNG(icon);
        File.WriteAllBytes(Application.dataPath + "/images/mace_2.png", bytes);
        
        icon = AssetPreview.GetAssetPreview(GameObject.Find("Mace1H_Epic")); 
        bytes = ImageConversion.EncodeToPNG(icon);
        File.WriteAllBytes(Application.dataPath + "/images/mace_3.png", bytes);
        
        icon = AssetPreview.GetAssetPreview(GameObject.Find("Mace2H_Basic")); 
        bytes = ImageConversion.EncodeToPNG(icon);
        File.WriteAllBytes(Application.dataPath + "/images/mace_4.png", bytes);
        
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
