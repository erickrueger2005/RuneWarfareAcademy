/// <summary>
/// This script belongs to cowsins™ as a part of the cowsins´ FPS Engine. All rights reserved. 
/// </summary>
using UnityEngine;
using UnityEngine.UI;

namespace cowsins
{

    public class CustomCrosshair : MonoBehaviour
    {
        #region variables

        [Tooltip("Attach your PlayerMovement player "), SerializeField]
        private PlayerMovement player;

        private PlayerStats playerStats;

        private WeaponController weaponController;

        private InteractManager interactManager;

        private Rigidbody rb;

        private Image crosshairImg;
        [SerializeField] private Texture2D crosshair;

        [SerializeField, Tooltip("If enabled, the crosshair will not be displayed when the game is paused.")] private bool hideCrosshairOnPaused;

        [SerializeField, Tooltip("If enabled, the crosshair will not be displayed when the player is inspecting.")] private bool hideCrosshairOnInspecting;


        #endregion

        private void Awake()
        {
            playerStats = player.GetComponent<PlayerStats>();
            weaponController = player.GetComponent<WeaponController>();
            interactManager = player.GetComponent<InteractManager>();
            rb = player.GetComponent<Rigidbody>(); 

            crosshairImg = GetComponent<Image>(); 
            //crosshairImg.enabled = false;
        }

        private void Update()
        {
         
        }


        /// <summary>
        /// Draw the crosshair as our UI
        /// </summary>
        void OnGUI()
        {
            if (playerStats.isDead
                || weaponController.weapon != null && weaponController.isAiming && player.weapon.removeCrosshairOnAiming
                || PauseMenu.Instance != null && PauseMenu.isPaused && hideCrosshairOnPaused
                || interactManager.inspecting && hideCrosshairOnInspecting) return;
            GUI.DrawTexture(new Rect(Screen.width / 2 - crosshair.width/2, Screen.height / 2 - crosshair.height/2 +3, crosshair.width, crosshair.height), crosshair);
        }
    }
}