using System;
using System.Drawing;
using System.Windows.Forms;

namespace Avionics
{
    class AttitudeIndicator : Control
    {
        #region Fields

        // Parameters
        double PitchAngle = 0; // Phi
        double RollAngle = 0; // Theta

        // Images
        Bitmap bmpBackground = new Bitmap(Avionics.AvionicsResources.Horizon_Background);
        Bitmap bmpGroundSky = new Bitmap(Avionics.AvionicsResources.Horizon_GroundSky);
        Bitmap bmpAircraft = new Bitmap(Avionics.AvionicsResources.Maquette_Avion);

        #endregion

        #region Contructor

        /// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

        public AttitudeIndicator()
        {
            // Double bufferisation
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint, true);
        }

        #endregion

        #region Component Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
        }
        #endregion

        #region Paint

        protected override void OnPaint(PaintEventArgs pe)
        {
            // Calling the base class OnPaint
            base.OnPaint(pe);

            // Pre Display computings

            Point ptBoule = new Point(25, -210);
            Point ptRotation = new Point(150, 150);

            float scale = (float)this.Width / bmpBackground.Width;

            // Affichages - - - - - - - - - - - - - - - - - - - - - - 

            bmpBackground.MakeTransparent(Color.Red);
            bmpAircraft.MakeTransparent(Color.Red);

            // display GroundSky
            RotateAndTranslate(pe, bmpGroundSky, RollAngle, 0, ptBoule, (int)(4 * PitchAngle), ptRotation, scale);

            // display Background
            pe.Graphics.DrawImage(bmpBackground, 0, 0, (float)(bmpBackground.Width * scale), (float)(bmpBackground.Height * scale));

            // display Aircraft
            pe.Graphics.DrawImage(bmpAircraft, (float)((0.5 * bmpBackground.Width - 0.5 * bmpAircraft.Width) * scale), (float)((0.5 * bmpBackground.Height - 0.5 * bmpAircraft.Height) * scale), (float)(bmpAircraft.Width * scale), (float)(bmpAircraft.Height * scale));

        }

        #endregion

        #region Methods

        /// <summary>
        /// Define the physical value to be displayed on the indicator
        /// </summary>
        /// <param name="aircraftPitchAngle">The aircraft pitch angle in °deg</param>
        /// <param name="aircraftRollAngle">The aircraft roll angle in °deg</param
        public void SetAttitudeIndicatorParameters(double aircraftPitchAngle, double aircraftRollAngle)
        {
            PitchAngle = aircraftPitchAngle;
            RollAngle = aircraftRollAngle * Math.PI / 180;

            this.Refresh();
        }

        #endregion

    }
}
